Aplikace je naprogramována na framework Django.

Aplikace podporuje správu pojištěnců a to jejich vytvoření, úpravu, smazání a k nim přidružené pojištění. V databázi je již vytvořeno několik pojištěnců pro demonstraci.
Pro aplikaci jsou vytvořeny tři uživatelské role. Předpoklad požití je například v pojišťovací společnosti kdy se zaměstnanci nejříve zaregistrují do databáze a mají možnost
výpisu pojištěnců ale nemají práva pro editaci, mazání nebo tvorbu. To následně řeší přístup vyššího postu.
Máme tedy tři typy přístupů:

1: Bez přihlášení nevypíše nic kromě základního navigačního menu a žádosti o přihlášení.

2: Do aplikace se lze zaregistrovat nebo využít připraveného profilu, přihlašovací údaje níže. Po přihlášení se vypisují údaje o pojištěncích a pojistkách ale nelze data
   nijak upravovat nebo mazat.

3: Po přihlášení do účtu s právy (administrátorský účet) lze tvořit, upravovat nebo mazat.


Pojištění je napojeno na pojištěnce, je-li tedy pojištěnec smazán je s ním smazáno i pojištění.


Uživatelský účet:
email: uzivatel@uzivatel.cz
heslo: uzivatel

Aministrátor:
email: admin@admin.cz
heslo: admin


Docker:

- Aplikaci lze stáhnout do Dockeru příkazem 'docker pull dvorakj/pojistenci:latest'
- Aplikaci spustíme příkazem: 'docker run --publish 8000:8000 dvorakj/pojistenci'
- Aplikace běží pod portem 8000 (http://localhost:8000/)