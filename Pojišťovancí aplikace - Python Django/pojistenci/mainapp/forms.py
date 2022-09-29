from django import forms
from .models import Pojisteni,Pojistenec,Uzivatel,ZalozenaPojisteni

# Formulář typu pojištění
class PojisteniForm(forms.ModelForm):

    class Meta:
        model = Pojisteni
        fields=["nazev"]

# Formulář pojištěnců
class PojistenciForm(forms.ModelForm):

    class Meta:
        model = Pojistenec
        fields =["Jmeno","Prijmeni","email","tel","mesto","ulice","PSC"]

# Formulář pro založení pojištění
class ZalozitPojisteniForm(forms.ModelForm):

    class Meta:
        model = ZalozenaPojisteni
        fields =["pojistenec","pojistka","castka","platnost_od","platnost_do","predmet_pojisteni"]
       # widgets = {'pojistenec': forms.HiddenInput()}

# Formulář registrace uživatele
class RegisterForm(forms.ModelForm):
    password = forms.CharField(widget = forms.PasswordInput)

    class Meta:
        model = Uzivatel
        fields = ["email","password"]

# Formulář přihlášení uživatele
class LoginForm(forms.Form):
    email = forms.CharField()
    password = forms.CharField(widget=forms.PasswordInput)

    class Meta:
        fields = ["email","password"]
