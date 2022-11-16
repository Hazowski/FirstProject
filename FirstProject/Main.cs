using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

/*
 * 1.Zaprojektuj funkcje, która będzie zwracała użytkowników. Użytkownicy mają takie pola jak, imię, wiek, rodzaj konta (free, premium, admin),
 * oraz zwierzę które będzie posiadało imie, i wiek (samo zwierze jest polem opcjonalnym). Użykownik dodatkowo będzie miał także listę ostatnich logowań. 
 * Użytkownik ma możliwość zmienienia zwierzecia oraz rodzaju konta. Każdy użytkownik również bedzie miał identyfikator, którego nie można pobrać, 
 * i dla każdego użytkownika będzie on miał wartość "iden". Stwórz funkcje która będzie umożliwiała na podstawie rodzaju konta i daty ostatniego logowania zwrócić 
 * wartość za ile dni zostanie usunięte konto użytkownika. Jeżeli jest to free to zostanie usunięte po 7 dniach od ostatniego logowania, dla premium to 30 dni, a dla admina nie ma takiej daty.
 * */

namespace FirstProject
{
    public class Main
    {
        
        List<User> UserList = new List<User>();  

        
       

        

        public void Stat(){

            var user2 = new User("Andrzej", "28", AccountType.premium,new DateTime(1994,2,2), new Pet("Burek", 12)); 
            var user3 = new User("Jan", "58", AccountType.free, new DateTime(2021,2,2));

            UserList.Add(user2);
            UserList.Add(user3);

          


                
            user2.ChangeAccountType(AccountType.admin);


            int i = 0;           
            foreach (var user in UserList)
            {
                i++;
                var accountTime = user.TimeToDeleteAccount();


               
                Console.WriteLine($"Imie uzytkownika {i}: {user.Name}, jego wiek {user.Age}, typ konta: {user.AccountType}, Data ostatniego logowania {user.LastLogin}, Opcjonalne imie psa i wiek: {user.Pet?.Name} , {user.Pet?.Age}, Konto zostanie usunięte za {accountTime}");
            }
            
           


        }

      
    }
}
