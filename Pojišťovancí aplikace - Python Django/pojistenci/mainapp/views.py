from django.shortcuts import render, HttpResponse
from .models import Pojisteni,Pojistenec,Uzivatel, ZalozenaPojisteni
from .forms import PojisteniForm, PojistenciForm,RegisterForm,LoginForm,ZalozitPojisteniForm
from django.contrib.auth import login, logout, authenticate
from django.shortcuts import redirect, reverse
from django.views import generic
from django.contrib import messages
from django.contrib.auth.mixins import LoginRequiredMixin
# Create your views here.

# Index aplikace pro vypsání listu pojištěnců
class index(generic.ListView):
    template_name = "mainapp/index.html"
    context_object_name = "pojistenci"

    # Získání listu pojištěnců z databáze
    def get_queryset(self):
      return Pojistenec.objects.all().order_by("-id")

    # Požadavek pro smazání
    def post(self, request):

        # Získá zaslané id
        moje_id = request.POST.get('pojistenec_id',"")

        # Získá pojištěnce dle id
        pojistenec = Pojistenec.objects.get(id=moje_id)

        # Jesliže je uživatel admin smaže pojištěnce
        if request.user.is_admin:
            messages.info(request, "Pojistěnec smazán")
            pojistenec.delete()

        return redirect(reverse("index"))

# Třída pro detail pojištěnce
class CurrentDetailPojistenec(generic.DetailView,generic.ListView):
    model = Pojistenec
    template_name = "mainapp/detail_pojistence.html"


    def get(self,request,pk):

        # Pokusí se načít pojištěnce
        try:
            pojistenec = self.get_object()
        except:
            return redirect("index")

        # Získá pojištění z databáze
        list_pojisteni = ZalozenaPojisteni.objects.all().order_by("-id")

        # Vytvoří prázdný list
        muj_list = []

        # Pro každé pojištění v listu pojištění
        for i in list_pojisteni:
            # Jesliže je pojištěnec uloženém v pojištění
            if str(pojistenec) in str(i):
                # Připojí pojištění do listu
                muj_list.append(i)

        # Jesliže je list prázný nastaví se mu hodnota None
        if len(muj_list) == 0:
            muj_list = None

        # Navrátí detail pojištěnce a jeho pojištění v aktuálním listu
        return render(request,self.template_name,{"pojistenec":pojistenec,"list":muj_list})

    def post(self,request,pk):
        if request.user.is_authenticated:

            # Jestliže není uživatel admin
            if not request.user.is_admin:
                messages.error(request, "Nedostatečná práva pro smazání nebo úpravu")
                return redirect(reverse("index"))

            # Jinak umožní upravu, smazání a vytvoření
            else:
                # Když přijde požadavek na úpravu pojištěnce
                if "upravit" in request.POST:
                    return redirect("uprav_pojistence",pk=self.get_object().pk)

                # Když přijde požadavek na smazání pojištěnce
                elif "smazat" in request.POST:
                    messages.info(request, "Pojistěnec smazán")
                    self.get_object().delete()

                # Když je požadavek na přidání pojištění
                elif "pridat_pojisteni" in request.POST:
                    return redirect("zaloz_pojisteni",pk=self.get_object().pk)

                # Když přijde v požadavku pojistka_id smaže pojistku dle id
                elif "pojistka_id" in request.POST:

                    # Získá zaslané id a podle toho id pojistky a následně ji smaže
                    moje_id = request.POST.get('pojistka_id', "")
                    pojistka = ZalozenaPojisteni.objects.get(id=moje_id)

                    messages.info(request, "Pojistka smazána")
                    pojistka.delete()
                    return redirect("detail_pojistence", pk=self.get_object().pk)

        return redirect(reverse("index"))

# Třída pro detail pojistky
class CurrentDetailPojisteni(generic.DetailView,generic.ListView):
    model = ZalozenaPojisteni
    template_name = "mainapp/detail_pojistky.html"

    # Pokusí se načíst pojistku
    def get(self,request,pk):
        try:
            pojistka = self.get_object()
        except:
            return redirect("index")

        return render(request,self.template_name,{"pojistka":pojistka})

    def post(self,request,pk):
        if request.user.is_authenticated:

            # Jesliže uživatel není admin
            if not request.user.is_admin:
                messages.error(request, "Nedostatečná práva pro smazání nebo úpravu")

            # Jinak umožní úpravu a smazání
            else:
                if "upravit" in request.POST:
                    return redirect("uprav_pojisteni",pk=self.get_object().pk)
                elif "smazat" in request.POST:
                    messages.info(request, "Pojištění smazáno")
                    self.get_object().delete()

        return redirect(reverse("index"))

# Třída pro založení pojistky
class ZalozPojisteni(generic.edit.CreateView):
    form_class = ZalozitPojisteniForm
    template_name = "mainapp/zaloz_pojisteni.html"
    nadpis = "Přidat pojištění k " # Začátek nadpisu pro template, následně doplněný o jméno pojištěnce


    def get(self, request, pk):

        # Jestliže není uživatel přihlášen navrátí se na index
        if not request.user.is_authenticated:
            messages.error(request, "Nejste přihlášen")
            return redirect("index")
        pojistenec = Pojistenec.objects.get(pk=pk)

        # Automaticky vloží do pojistky pojištěnce ze kterého byl požadavek zaslán
        form = self.form_class(initial={'pojistenec':pojistenec})
        return render(request,self.template_name,{"form":form,'pojistenec':pojistenec,'nadpis':self.nadpis})

    def post(self,request,pk):

        form = self.form_class(request.POST)
        pojistenec = Pojistenec.objects.get(pk=pk)

        if form.is_valid():
            if request.user.is_admin:
                form.save(commit=True)
                messages.info(request, "Pojištění bylo uloženo")
                return redirect("detail_pojistence",pk=pojistenec.id)
            else:
                messages.error(request, "Nedostatečná práva")
                return redirect("index")

        # Navrátí formulář pro založení pojistky a nadpis s jménem pojištěnce
        return render(request, self.template_name, {"form": form,"pojistenec":pojistenec,'nadpis':self.nadpis})

# Třída pro editaci pojištění
class EditPojistky(LoginRequiredMixin,generic.edit.CreateView):
    form_class = ZalozitPojisteniForm
    template_name = "mainapp/zaloz_pojisteni.html"
    nadpis = "Upravit pojištění" # Začátek nadpisu pro template, následně doplněný o jméno pojištěnce

    def get(self,request,pk):

        # Jestliže není uživatel přihlášen navrátí se na index
        if not request.user.is_admin:
            messages.error(request, "Nedostatečná práva pro úpravu")
            return redirect("index")

        # Pokusí se načíst pojištění
        try:
            pojistka = ZalozenaPojisteni.objects.get(pk=pk)
        except:
            messages.error(request, "Toto pojištění neexistuje")
            return redirect("index")

        # načte si instanci pojištění do formuláře
        form = self.form_class(instance=pojistka)

        # Navrátí již vyplněný formulář původními informacemi
        return render(request,self.template_name,{"form": form,'nadpis':self.nadpis,"pojistenec":pojistka.pojistenec})

    def post(self,request,pk):
        if not request.user.is_admin:
            messages.info(request, "Nedostatečná práva pro úpravu")
            return redirect("index")

        form = self.form_class(request.POST)

        if form.is_valid():

            # Načte vložená data z formuláře do proměných
            pojistka = form.cleaned_data["pojistka"]
            pojistenec = form.cleaned_data["pojistenec"]
            castka = form.cleaned_data["castka"]
            platnost_od = form.cleaned_data["platnost_od"]
            predmet_pojisteni = form.cleaned_data["predmet_pojisteni"]
            platnost_do = form.cleaned_data["platnost_do"]

            # Pokusí se načíst pojištění
            try:
                zalozena_pojistka = ZalozenaPojisteni.objects.get(pk = pk)
            except:
                messages.error(request,"Tento pojištěnec neexistuje")
                return redirect("index")

            # Následně vloží data do upravovaného pojištění
            zalozena_pojistka.predmet_pojisteni = predmet_pojisteni
            zalozena_pojistka.pojistka = pojistka
            zalozena_pojistka.pojistenec = pojistenec
            zalozena_pojistka.castka = castka
            zalozena_pojistka.platnost_od = platnost_od
            zalozena_pojistka.platnost_do = platnost_do
            zalozena_pojistka.save()
            messages.info(request, "Úprava pojistky uložena")
            return redirect("detail_pojistence", pk=pojistenec.id)

        return redirect("index")

# Třídat pro editaci pojištěnce
class EditPojistence(LoginRequiredMixin,generic.edit.CreateView):
    form_class = PojistenciForm
    template_name = "mainapp/vytvor_pojistence.html"
    nadpis = "Úprava pojištěnce" # Začátek nadpisu pro template, následně doplněný o jméno pojištěnce

    def get(self,request,pk):

        # Jestliže není uživatel admin navrátí se na index
        if not request.user.is_admin:
            messages.error(request, "Nedostatečná práva pro úpravu Pojištěnce.")
            return redirect("index")

        # Pokusí se načíst pojištěnce
        try:
            pojistenec = Pojistenec.objects.get(pk=pk)
        except:
            messages.error(request, "Tento pojištěnec neexistuje")
            return redirect("index")

        # načte si instanci pojitěnce do formuláře
        form = self.form_class(instance=pojistenec)

        # Navrátí již vyplněný formulář původními informacemi
        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis,"pojistenec":pojistenec})

    def post(self,request,pk):
        if not request.user.is_admin:
            messages.error(request, "Nedostatečná práva pro úpravu pojištěnce.")
            return redirect("index")

        form = self.form_class(request.POST)

        if form.is_valid():

            # Načte vložená data z formuláře do proměných
            jmeno = form.cleaned_data["Jmeno"]
            prijmeni = form.cleaned_data["Prijmeni"]
            email = form.cleaned_data["email"]
            tel = form.cleaned_data["tel"]
            mesto = form.cleaned_data["mesto"]
            ulice = form.cleaned_data["ulice"]
            psc = form.cleaned_data["PSC"]

            # Pokusí se načíst pojištěnce
            try:
                pojistenec = Pojistenec.objects.get(pk = pk)
            except:
                messages.error(request,"Tento pojištěnec neexistuje")
                return redirect("index")

            # Následně vloží data do upravovaného pojištěnce
            pojistenec.Jmeno = jmeno
            pojistenec.Prijmeni = prijmeni
            pojistenec.email = email
            pojistenec.tel = tel
            pojistenec.mesto = mesto
            pojistenec.ulice = ulice
            pojistenec.PSC = psc
            pojistenec.save()
            messages.info(request, "Úprava pojištěnce uložena")
        return redirect("index")

# Třída pro založení pojištěnce
class CreatePojistence(generic.edit.CreateView):

    form_class = PojistenciForm
    template_name="mainapp/vytvor_pojistence.html"
    nadpis = "Vytvořit pojištěnce" # Nadpis pro template

    def get(self,request):
        form = self.form_class(None)

        # Navrátí formulář a nadpis
        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis})

    def post(self,request):
        form = self.form_class(request.POST)
        if form.is_valid():
            form.save(commit=True)
            messages.info(request, "Pojištěnec byl uložen")
            return redirect("index")
        return render(request,self.template_name,{"form":form})

# Třída por vypsání listu pojištění
class PojisteniListView(generic.ListView):

    template_name = "mainapp/pojisteni.html"
    context_object_name = "pojistky"

    # Získá list pojištění seřazených dle id
    def get_queryset(self):
        return ZalozenaPojisteni.objects.all().order_by("-id")

# Třída pro vytvoření TYPU pojištění
class CreatePojisteni(generic.edit.CreateView):

    from_class = PojisteniForm
    template_name="mainapp/vytvor_pojisteni.html"

    def get(self,request):
        form = self.from_class
        return render(request,self.template_name,{"form":form})

    def post(self,request):
        form = self.from_class(request.POST)
        if form.is_valid():
            form.save(commit=True)
            return redirect("index")

        return render(request,self.template_name,{"form":form})

# Třída pro registraci uživatele
class UzivatelViewRegistrace(generic.edit.CreateView):

    form_class = RegisterForm
    template_name = "mainapp/uzivatel_form.html"
    nadpis = "Registrace" # Nadpis pro template

    def get(self, request):
        form = self.form_class
        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis})

    def post(self,request):
        form = self.form_class(request.POST)
        if form.is_valid():

            # Nejdříve se zabrání uložení předtím než z hesla neuděláme hash
            uzivatel = form.save(commit = False)

            # Získáme heslo z formuláře
            password = form.cleaned_data["password"]

            # Metoda set_password nám zajistí hash hesla
            uzivatel.set_password(password)
            uzivatel.save()

            # Po uložení se zavolá metoda na login uživatele
            login(request,uzivatel)
            messages.info(request, "Regisrace úspěšná")
            return redirect("index")

        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis})

# Třída pro login uživatele
class UzivatelViewLogin(generic.edit.CreateView):

    form_class = LoginForm
    template_name = "mainapp/uzivatel_form.html"
    nadpis = "Login" # Nadpis pro template

    def get(self, request):
        form = self.form_class
        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis})

    def post(self,request):
        form = self.form_class(request.POST)
        if form.is_valid():

            # Načte email a heslo z formuláře
            email = form.cleaned_data["email"]
            password = form.cleaned_data["password"]

            # autentizace emailu a hesla
            uzivatel = authenticate(email = email,password = password)
            if uzivatel:
                #Login uživatele
                login(request,uzivatel)
                messages.info(request, "Přihlášeno")
                return redirect("index")

            # Jesliže se přihlášení nepovede vyvolá chybovou hlášku
            else:
                messages.error(request, "Email nebo heslo není správně")

        return render(request,self.template_name,{"form":form,"nadpis":self.nadpis})

# Metoda pro odhlášení
def logout_user(request):
    logout(request)
    return redirect("index")

# Třída pro vypsání stránky O aplikaci
class about(generic.edit.CreateView):

    form_class = "mainapp/about.html"

    def get(self,request):
        return render(request,self.form_class)

