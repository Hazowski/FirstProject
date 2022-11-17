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
        public void Stat()
        {
            List<User> UserList = new()
            {
                new User("Andrzej", "28", AccountType.Premium,new DateTime(1994,2,2), new Pet("Burek", 12)),
                new User("Jan", "58", AccountType.Free, new DateTime(2022,11,11))
            };          

         
            for (int i = 0; i < UserList.Count; i++)
            {
                Console.WriteLine($"Imie uzytkownika {i}: {UserList[i].Name}, jego wiek {UserList[i].Age}, typ konta: {UserList[i].AccountType}, Data ostatniego logowania {UserList[i].LastLogin}, Opcjonalne imie psa i wiek: {UserList[i].Pet?.Name} , {UserList[i].Pet?.Age}, Konto zostanie usunięte za {UserList[i].TimeToDelete}");
            }
        }
    }
}
