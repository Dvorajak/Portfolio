
class Pojisteni:

    # Založí prázný list
    listPojistenych = []

    # Metoda pro založení pojištěnce
    def Zalozit(self,jmeno,primeni,vek,tel):
        self.listPojistenych +=[f"Jméno: {jmeno}   Přijmení: {primeni}   Věk:{vek}   Tel:{tel}"]
        input("Data uložena, pokračujte libovolnou klávesou...\n")

    # Metoda pro vypsání listu pojištěnců
    def Vypsat(self):

        # Jestliže je list prázný
        if len(self.listPojistenych) == 0:
            print("------------------------------------------")
            print("Žádné záznamy")
            print("------------------------------------------\n")
            input("Pokračujte libovolnou klávesou...\n")

        # Jinak vypíše pojištěnce
        else:
            print(f"Záznamy: {len(self.listPojistenych)}")
            print("------------------------------------------")
            for i in range(len(self.listPojistenych)):
                print(f"{i+1}:",self.listPojistenych[i])
            input("Pokračujte libovolnou klávesou...\n")

    # Metoda pro vyhledání pojištěnců
    def Vyhledej(self):

        # Jestliže je list prázný
        if len(self.listPojistenych) == 0:
            print("------------------------------------------")
            print("Žádné záznamy")
            print("------------------------------------------\n")
            input("Pokračujte libovolnou klávesou...\n")
            return


        jmeno = input("Zadejte jméno: \n")
        prijmeni = input("Zadejte přijmení: \n")
        nalezeno = False

        # For smyčka pro vyhledání pojištěnce
        for i in range(len(self.listPojistenych)):
            if jmeno in self.listPojistenych[i] and prijmeni in self.listPojistenych[i]:
                print("Záznam nalezen:")
                print(self.listPojistenych[i])
                nalezeno = True

        # Jesliže nebyl pojištěnec nalezen
        if not nalezeno:
            print("Záznam nenalezen")


        input("Pokračujte libovolnou klávesou...\n")

