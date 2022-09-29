#Třída na konverzi ze stringu na integer
class Parse:

    def Parse(self,str):
        try:
            return int(str), True
        except:
            print("\n!!!------------------------------------!!!")
            print("Zadejte prosím jen čísla")
            print("!!!--------------------------------------!!!\n")
            return str, False