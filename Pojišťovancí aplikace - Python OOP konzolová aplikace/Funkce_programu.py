from Try_Parse import Parse #Import konverze stringu
from Pridej_Pojistence import Pridat #Import třídy na přidání pojištěnce
from Pojistenci import Pojisteni  #Aktualni zaznamy o pojištěncich
import datetime

#Hlavní třída funkcí programu
class Funkce:
    parseINT = Parse()

    # Metoda uvítací zprávy
    def Pozdrav(self):
        now = datetime.datetime.now()
        ted = now.strftime("%d.%m.%Y")
        print("------------------------------------------")
        print(f"Evidence pojištěných - Dnes je {ted}")
        print("------------------------------------------")

    # Metoda pro nabídku akcí
    def HlavniMenu(self):
        print("Vyberte si akci:")
        print("1 - Přidat nového pojistného \n2 - Vypsat všechny pojištěné \n3 - Vyhledat pojištěného \n4 - Konec")

        # Získání vstupu od uživatele s požadovnou akcí
        akce = input()

        # Jestliže uživatel zadá něco jiného než čísla a konverze se neprovede
        if False in self.parseINT.Parse(akce):
            # Navrátí nabídku akcí
            self.HlavniMenu()
        else:
            # Jestliže konverze byla úspěšná převede string na integer
            self.akce = int(akce)

        # Pokud užvatel zadá špatnou akci
        if not self.akce in range(1,5):
            print("!!!------------------------------------!!!")
            print("Špatné zadání")
            print("!!!------------------------------------!!!\n")
            # Navrátí nabídku akcí
            self.HlavniMenu()

        # Vytvoří instanci pro přidání záznamu
        pridat = Pridat()

        # Vytvoří instanci pro založené pojištění
        zaznam = Pojisteni()

        match self.akce: 
            case 1:
                # Vyvolá metodu na přidání pojištěnce
                pridat.Pridej()
            case 2:
                # Vyvolá metodu na vypsání pojištěnce
                zaznam.Vypsat()
            case 3:
                # Vyvolá metodu na vyhledání pojištěnce
                zaznam.Vyhledej()
            case 4:
                # Jestliže uživatel zadá možnost 4 navrátí True na ukončení programu do hlavní metody
                return True
        return self.HlavniMenu()