using ConsoleApp9.Enums;

namespace ConsoleApp9;

class Employ
{
    public Country Country;
    public Gender Gender;
    public Contacts Contacts;
    public string Name;
    public string Surname;
    public DateTime DateOfBirth;

    public Employ(Country country, Gender gender, Contacts contacts, string name, string surname, DateTime dateOfBirth)
    {
        Country = country;
        Gender = gender;
        Contacts = contacts;
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
    }

    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        Console.WriteLine($"{Name} {Surname} age: {age}");
        return age;
    }
}