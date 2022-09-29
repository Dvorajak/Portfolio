#Naimportuje hlavní funkce programu
from Funkce_programu import Funkce
funkcePojisteni = Funkce()

#Výchozí hodnuta ukončení programu
konec = False

#Jestliže uživatel nepotvrdí konec
while konec == False:

    #Zavolá pozdrav
    funkcePojisteni.Pozdrav()

    #Navrácená hodnota konce jestliže uživatel potvrdí konec ve funkcích programu
    konec = funkcePojisteni.HlavniMenu()



