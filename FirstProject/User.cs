using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.Zaprojektuj funkcje, która będzie zwracała użytkowników. Użytkownicy mają takie pola jak, imię, wiek, rodzaj konta (free, premium, admin),
 * oraz zwierzę które będzie posiadało imie, i wiek (samo zwierze jest polem opcjonalnym). Użykownik dodatkowo będzie miał także listę ostatnich logowań. 
 * Użytkownik ma możliwość zmienienia zwierzecia oraz rodzaju konta. Każdy użytkownik również bedzie miał identyfikator, którego nie można pobrać, 
 * i dla każdego użytkownika będzie on miał wartość "iden". Stwórz funkcje która będzie umożliwiała na podstawie rodzaju konta i daty ostatniego logowania zwrócić 
 * wartość za ile dni zostanie usunięte konto użytkownika.
 * Jeżeli jest to free to zostanie usunięte po 7 dniach od ostatniego logowania, dla premium to 30 dni, a dla admina nie ma takiej daty.
 * */
namespace FirstProject
{
    public enum AccountType
    {
        free,
        premium,
        admin,
    }

    public class User
    {       

        public string Name { get; set; }
        public AccountType AccountType { get; set; }
        public string Age { get; set; }
        
        public Pet Pet { get; set; } 
    
        public DateTime LastLogin { get; set; }

        public void ChangeAccountType(AccountType accountType)
        {

            AccountType= accountType;
        }

        public double Afk()
        {            
            return (DateTime.Now - LastLogin).TotalDays;
        }

        public double? TimeToDeleteAccount()
        {
            var dayAfk = Afk();

            return AccountType switch
            {
                AccountType.admin => null,
                AccountType.free => 7 - dayAfk,
                AccountType.premium => 30 - dayAfk,
                _ => null,
            };
        }


        public User(string name, string age, AccountType accountType, DateTime lastLogin, Pet? pet=null) { 

            Name= name;
            Age = age;
            AccountType = accountType;
            LastLogin = lastLogin;
            Pet = pet;          
        }   
      



            

    }
}
