# BaigiamasisDarbasKnygos.lt
 ## [Knygos.lt](https:www.knygoslt)

  1. Login scenario
  
  (Precondition: website is open)   

         1.1 Click "Prisijungti,registruotis"
         1.2 Enter "El.pašto adresas" (with: de141488@gmail.com)
         1.3 Enter "Slaptažodis" (with: Demo881414)
         1.4 Click "Prisijungti"
         1.5 Assert that vissible title "Mano paskyra"

  2. Product list scenario 
  
  (Precondition: website is open and user is login) 
    
    2.1 Product search scenario

         2.1.1 Click title "Visos knygos"
         2.1.2 Click "Grožinė literatūra"
         2.1.3 Click "Klasika"
         2.1.4 Click book icon
         2.1.5 Assert that vissible button "Pirkinių krepšelis"

    2.2 Quick product search and save to favorite
        
         2.2.1 Enter book name to search 
         2.2.3 Click to book icon
         2.2.4 Click to heart icon
         2.2.5 Assert that vissible red heart icon

  3. Sell your book scenario

  (Precondition: website is open and user is login)
         
         3.1 Click "Mano paskyra" 
         3.2 Click "Skaitytos knygos"
         3.3 Click "Pradėti prekybą"
         3.4 Click "Pradėti"
         3.5 Assert that title is vissible

  4. Subscribe scenario

  (Precondition: website is open and user is login)

         4.1 Enter "El.pašto adresas" (with: de141488@gmail.com)
         4.2 Click "Sutinku gauti bendro pobūdžio laiškus"
         4.3 Click "Sutinku gauti pasiūlymus ir paklausimus"
         4.4 Click "Prenumeruoti" 
         4.5 Assert that is vissible title "Naujienlaiškių prenumerata patvirtinta"





  