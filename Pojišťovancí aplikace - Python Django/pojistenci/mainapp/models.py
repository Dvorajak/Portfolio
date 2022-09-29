from django.db import models
from django.contrib.auth.models import AbstractBaseUser, BaseUserManager

# Create your models here.

# Uživatelský modelManager
class UzivatelskyManager(BaseUserManager):

    # Metoda pro vytvoření uživatele
    def create_user(self,email,password):
        print(self.model)
        if email and password:
            user = self.model(email=self.normalize_email(email))
            user.set_password(password)
            user.save()
        return user

    # Metoda pro vytvoření super uživatele
    def create_superuser(self,email,password):

        # vytvoří objekt metody pro vytvoření uživatele
        user = self.create_user(email,password)

        # přiřadí administrátorské práva
        user.is_admin = True
        user.save()
        return user

# Uživatelský model
class Uzivatel(AbstractBaseUser):

    # pole emailu a zda je uživatel admin
    email = models.EmailField(max_length = 300, unique = True)
    is_admin = models.BooleanField(default=False)

    # Pojmenování tabulky v databázi
    class Meta:
        verbose_name = "uživatel"
        verbose_name_plural = "uživatelé"

    # Jako obekt je uživatelský manager
    object = UzivatelskyManager()

    # Jméno uživatele je jeho email pro přihlášení
    USERNAME_FIELD = "email"

    def __str__(self):
        return f"email: {self.email}"

    @property
    def is_staff(self):
        return self.is_admin

    def has_perm(self,app):
        return True

    def has_module_perms(self,app_label):
        return True

# Model typu pojištění
class Pojisteni(models.Model):
    nazev = models.CharField(max_length=180,verbose_name = "Název")

    # Pojmenování tabulky v databázi
    class Meta:
        verbose_name = "Pojištění"
        verbose_name_plural = "Pojištění"

    # Při vyvolání navrátí název pojištění
    def __str__(self):
        return f"{self.nazev}"

# Model pojištěnce
class Pojistenec(models.Model):
    Jmeno = models.CharField(max_length=20,verbose_name = "Jméno")
    Prijmeni = models.CharField(max_length=20,verbose_name = "Přijmení")
    email = models.EmailField(max_length=80, unique=False)
    tel = models.IntegerField()
    mesto = models.CharField(max_length=80,verbose_name = "Město")
    ulice = models.CharField(max_length=80)
    PSC = models.IntegerField(verbose_name = "PSČ")

    # Pojmenování tabulky v databázi
    class Meta:
        verbose_name = "Pojištěnec"
        verbose_name_plural = "Pojištěnci"

    # Při vyvolání navrátí Jméno a Přijmení
    def __str__(self):
        return f"{self.Jmeno} {self.Prijmeni}"

# Model pro založená pojištění k uživatelům
class ZalozenaPojisteni(models.Model):
    pojistka = models.ForeignKey(Pojisteni, null=True,verbose_name = "Pojištění", on_delete = models.SET_NULL)
    pojistenec = models.ForeignKey(Pojistenec, null=True,verbose_name = "Pojištěnec", on_delete = models.CASCADE)
    castka = models.IntegerField(null=True,blank=True,verbose_name = "Částka")
    predmet_pojisteni = models.CharField(max_length=80,null=True,blank=True, verbose_name = "Předmět pojištění")
    platnost_od = models.CharField(max_length=80,null=True,blank=True)
    platnost_do = models.CharField(max_length=80,null=True,blank=True)

    # Pojmenování tabulky v databázi
    class Meta:
        verbose_name = "Založena pojistka"
        verbose_name_plural = "Založené pojištění"

    # Při vyvolání navrátí pojistku, jméno a přijmení uživatele
    def __str__(self):
        return f"{self.pojistka} - {self.pojistenec}"

