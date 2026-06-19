using System;

class Student : Person, IPrintable
{
    public string Email { get; set; }
    public string Phone { get; set; }
    public double GPA { get; set; }
    public Faculty Faculty { get; set; }

    public Student(string name, string lastName, int age,
                   string email, string phone, double gpa, Faculty faculty)
        : base(name, lastName, age)
    {
        Email = email;
        Phone = phone;
        GPA = gpa;
        Faculty = faculty;
    }

    public void Print()
    {
        Console.WriteLine($"  სახელი : {Name} {LastName}");
        Console.WriteLine($"  ასაკი  : {Age}");
        Console.WriteLine($"  ფაკულტეტი   : {Faculty}");
        Console.WriteLine($"  GPA    : {GPA}");
        Console.WriteLine($"  Email  : {Email}");
        Console.WriteLine($"  ტელ.   : {Phone}");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{Name} {LastName} | {Age} წ. | {Faculty} | GPA: {GPA}");
    }

    public static bool operator >(Student a, Student b) => a.GPA > b.GPA;
    public static bool operator <(Student a, Student b) => a.GPA < b.GPA;
}
