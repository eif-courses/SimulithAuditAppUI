# Azure cloud autorizacijos sistemos B2C konfigūravimas

Paruošiamieji darbai pasirenkame Azure PowerShell CLI atidarius reikia sukurti Storage account, kad dirbti su konsole
<img width="832" alt="pirmas zingsnis" src="https://user-images.githubusercontent.com/8007447/213884913-bee67e28-4e1e-44ae-879c-dc01e3f17fbe.png">

Įvesti komandą ```Register-AzureRmResourceProvider -ProviderNamespace Microsoft.AzureActiveDirectory``` ir spustelėti enter klavišą jeigu viskas tvarkoje gausite tokį pranešimą

<img width="707" alt="trecias veiksmas" src="https://user-images.githubusercontent.com/8007447/213884964-9e10a504-ad98-434b-b50d-f2721fd1d7cb.png">

Pirmas žingsnis pasirinkti Create Resource

![image](https://user-images.githubusercontent.com/8007447/213881814-57796de5-e405-44a3-a6df-8016d101c8a2.png)

Antras žingsnis paeiškos laukelyje suvesti Azure Actice Directory B2C ir pasirinkti šią paslaugą

![image](https://user-images.githubusercontent.com/8007447/213881981-02184b06-3e0c-41bf-ae89-a763675f11bc.png)

Spausti Create ir sekančiame žingsnyje pasrinkti Create new tenant bei suvesti reikiamą informaciją

![image](https://user-images.githubusercontent.com/8007447/213882223-9bf6faa7-f629-4bce-bf48-2a83bc2a87fb.png)

Tada spausti Create 

![image](https://user-images.githubusercontent.com/8007447/213882263-dcdcd506-e3e8-4b4a-ad34-0f9438b3ff73.png)

Jeigu viskas tvarkoje pasirinkti kitą tenant (kaip atskira paskira) 
<img width="830" alt="image" src="https://user-images.githubusercontent.com/8007447/213885218-cef5a08a-e509-48f9-bea6-359abddb7120.png">
Pasirinkti App registrations ir New registration ir suvesti reikiamą informaciją -> spausti Register
![image](https://user-images.githubusercontent.com/8007447/213885478-7e96a777-24d2-4c4c-81ce-3b89a094059b.png)

Užregistravus šią progarmą pereiti lygiu atgal ir pasirinkti Azure AD B2C | User flows 
<img width="712" alt="image" src="https://user-images.githubusercontent.com/8007447/213886093-dbde14ab-0efa-49a3-875d-a79212b2c3ac.png">

Pasirinkti + New user flow ir naujai atsiradusiame lange Sign in and Sign Up -> Recommended 

<img width="866" alt="image" src="https://user-images.githubusercontent.com/8007447/213886196-04037c9c-1e69-4041-8ce8-2b61af935c4f.png">

Tada užpildyti informaciją susijusia su Sign in Sign up, todėl vadiname **susi**, bei 5 žingsnyje user attributes pasirenkame šiuos pažymėtus varnele, Return reiškia kaip GET (read only), o pirmame stulpelyje kaip SET (write, mutate value), bei galiausiai spaudžiame CREATE.
<img width="1280" alt="image" src="https://user-images.githubusercontent.com/8007447/213886393-0467a3bc-22a4-429a-8cf6-9d24949e9186.png">

Tada sekančiame žingsnyje, kuriame Profile edit User flow pavadimas bus **edit**

<img width="1265" alt="image" src="https://user-images.githubusercontent.com/8007447/213886563-dcd12df1-23c4-4eb8-9098-4f650e10fe71.png">

Toliau renkames password reset user flow ir pavadiname **reset**

<img width="1267" alt="image" src="https://user-images.githubusercontent.com/8007447/213886706-f7d07221-01a3-42a3-bab1-52c79cbbaa46.png">

Galiausiai sukurūs šiuos pagrindinius vartotojo prisijungimo veiksmus matysite tokį vaizdą

<img width="731" alt="image" src="https://user-images.githubusercontent.com/8007447/213886742-8572679b-c9b0-4693-ba72-428f91018045.png">

Tada atsidarius C# projektą ir appsettings.json faile įvesti reikiamus duomenis skirtus sujungti su azure B2C 

![image](https://user-images.githubusercontent.com/8007447/213886823-9c0ee42c-8fe0-46f3-87b0-d893fcc3d32f.png)

Domain vardą rasite čia 
![image](https://user-images.githubusercontent.com/8007447/213886857-166c94b4-0669-4f34-b7b7-e7786cc7bff5.png)

Client Id rasite čia

![image](https://user-images.githubusercontent.com/8007447/213886888-80638137-0d79-4bc9-8266-8e64097a8599.png)

Suvedūs informacija turi atrodyti pagal jūsų sukurtą tenant vardą panašiai kaip šiame paveikslėlyje
![image](https://user-images.githubusercontent.com/8007447/213887266-b109a5ea-4e52-4f0b-a68b-a81a092d0a47.png)

Paskutinis žingsnis nueiti į sukurtą Azure Active Directory B2C programą ir pažymėti pora nustatymų Access tokens, ID tokens checked

![image](https://user-images.githubusercontent.com/8007447/213887325-c1b92cd6-4a3f-4e08-8ae7-2a28bf97a0e4.png)

Taip pat Mongo DB sukurti duomenų bazę pvz. audit 

![image](https://user-images.githubusercontent.com/8007447/213887551-debdf693-d225-444e-97a9-8aa71434f156.png)

Bei įvesti mongo db connection string iš nemokamai sukurto cluster pvz. šiuo atveju naudojame pavadimu EIF-CLUSTER

![image](https://user-images.githubusercontent.com/8007447/213887594-63638704-ffbb-41a1-b823-1d368007d9ed.png)

Toliau pasirenkame Connect your application pasirenkame C#/NET ir nukopijuojame Connection string informaciją bei patalpiname į savo projekto appsettings.json

![image](https://user-images.githubusercontent.com/8007447/213887650-f98e0d9c-fbea-487b-9325-af0d2a947109.png)

Pavyzdys kaip atrodo suvesta informacija

![image](https://user-images.githubusercontent.com/8007447/213887672-62693286-d453-49cb-bc78-c62a55151896.png)



