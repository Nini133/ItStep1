using ConsoleApp9.Enums;
using ConsoleApp9;

Employ[] employs = new Employ[8]
{
    new Employ(Country.Georgia, Gender.Male,   Contacts.Phone, "Nino",  "Dolidze",  new DateTime(1990, 3, 15)),
    new Employ(Country.Georgia, Gender.Female, Contacts.Email, "Ana",    "Akhvlediani",   new DateTime(1995, 6, 18)),
    new Employ(Country.Armenia, Gender.Male,   Contacts.Phone, "Guram",    "Kashia",  new DateTime(1979, 9, 3)),
    new Employ(Country.Armenia, Gender.Female, Contacts.Email, "Neymar",    "Jr",   new DateTime(1985, 7, 22)),
    new Employ(Country.Turkey,  Gender.Male,   Contacts.Fax,   "Anna",  "Kobakhidze",   new DateTime(1992, 11, 5)),
    new Employ(Country.Turkey,  Gender.Female, Contacts.Email, "Salome",   "Kurashvili", new DateTime(2000, 4, 25)),
    new Employ(Country.USA,     Gender.Male,   Contacts.Fax,   "Giorgi", "Khvedelidze", new DateTime(1983, 12, 10)),
    new Employ(Country.USA,     Gender.Female, Contacts.Phone, "Luka",   "Chkheidze",  new DateTime(1988, 1, 30))
};

foreach (var e in employs)
    e.GetAge();

Console.WriteLine("\n-- Georgia --");
foreach (var e in FilterByCountry(Country.Georgia, employs))
    Console.WriteLine($"{e.Name} {e.Surname}");

static Employ[] FilterByCountry(Country country, Employ[] employs)
{
    int count = 0;
    foreach (var e in employs)
        if (e.Country == country) count++;

    Employ[] result = new Employ[count];
    int i = 0;
    foreach (var e in employs)
        if (e.Country == country) result[i++] = e;

    return result;
}