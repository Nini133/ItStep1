abstract class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public abstract void ShowInfo();
}
