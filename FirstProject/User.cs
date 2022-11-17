/*
 * 1.Zaprojektuj funkcje, która będzie zwracała użytkowników. Użytkownicy mają takie pola jak, imię, wiek, rodzaj konta (free, premium, admin),
 * oraz zwierzę które będzie posiadało imie, i wiek (samo zwierze jest polem opcjonalnym). Użykownik dodatkowo będzie miał także listę ostatnich logowań. 
 * Użytkownik ma możliwość zmienienia zwierzecia oraz rodzaju konta. Każdy użytkownik również bedzie miał identyfikator, którego nie można pobrać, 
 * i dla każdego użytkownika będzie on miał wartość "iden". Stwórz funkcje która będzie umożliwiała na podstawie rodzaju konta i daty ostatniego logowania zwrócić 
 * wartość za ile dni zostanie usunięte konto użytkownika.
 * Jeżeli jest to free to zostanie usunięte po 7 dniach od ostatniego logowania, dla premium to 30 dni, a dla admina nie ma takiej daty.
 * */
namespace FirstProject;
public class User
{

    public string Name { get; set; }
    public AccountType AccountType { get; set; }
    public string Age { get; set; }

    public Pet Pet { get; set; }

    public DateTime LastLogin { get; set; }
    public double? TimeToDelete => TimeToDeleteAccount();

    public User(string name, string age, AccountType accountType, DateTime lastLogin, Pet? pet = null)
    {
        Name = name;
        Age = age;
        AccountType = accountType;
        LastLogin = lastLogin;
        Pet = pet;
    }
    public void ChangeAccountType(AccountType accountType)
    {
        AccountType = accountType;
    }

    private double? TimeToDeleteAccount()
    {
        var dayAfk = (DateTime.Now - LastLogin).TotalDays;

        return AccountType switch
        {
            AccountType.Admin => null,
            AccountType.Free => 7 - dayAfk,
            AccountType.Premium => 30 - dayAfk,
            _ => null,
        };
    }








}

