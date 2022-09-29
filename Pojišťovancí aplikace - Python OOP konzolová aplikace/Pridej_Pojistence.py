from Try_Parse import Parse
from Pojistenci import Pojisteni

class Pridat:
    parseINT = Parse()
    zazanam = Pojisteni()

    # Metoda na přidání pojštěnce
    def Pridej(self):

        # Nastavení defaulutní hodnoty na False pro podmínku while
        ciselne = False

        jmeno = input("Zadejte jméno pojištěného: \n")
        prijmeni = input("Zadejte přijmení pojištěného: \n")

        # Smyčka pro koverzi proměnné vek a tel
        while not ciselne:
            vek = input("Zadejte věk pojištěného: \n")
            tel = input("Zadejte tel. číslo: \n")
            if False in self.parseINT.Parse(tel) or False in self.parseINT.Parse(vek):
                ciselne = False
            else:
                # Jesliže je konverze úspěšná uloží se do proměné True a tím se ukončí smyčka
                ciselne = True

        # Uložení do soukromých atributů
        self.__jmeno = jmeno
        self.__prijmeni = prijmeni
        self.__vek = vek
        self.__tel = tel

        # Zavolání metody na založení pojistníka
        self.zazanam.Zalozit(self.__jmeno,self.__prijmeni,self.__vek,self.__tel)

