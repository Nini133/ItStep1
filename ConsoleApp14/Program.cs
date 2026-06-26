using System;
using System.Collections.Generic;

class Program
{
    static List<string> students = new List<string>();
    static Dictionary<string, int> grades = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n══════════════════════════════════");
            Console.WriteLine("║    Student Grade Management System  ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║  1. Add Student                    ║");
            Console.WriteLine("║  2. Search Student                 ║");
            Console.WriteLine("║  3. Update Grade                   ║");
            Console.WriteLine("║  4. Show All Students              ║");
            Console.WriteLine("║  0. Exit                           ║");
            Console.WriteLine("══════════════════════════════════");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    SearchStudent();
                    break;
                case "3":
                    UpdateGrade();
                    break;
                case "4":
                    ShowAllStudents();
                    break;
                case "0":
                    Console.WriteLine("\nProgram exited. Goodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice! Please try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.WriteLine("\n--- Add Student ---");
        Console.Write("Enter name: ");
        string name = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty!");
            return;
        }

        if (grades.ContainsKey(name))
        {
            Console.WriteLine($"A student named '{name}' already exists!");
            return;
        }

        Console.Write("Enter grade (0-100): ");
        if (!int.TryParse(Console.ReadLine(), out int grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Grade must be a whole number between 0 and 100!");
            return;
        }

        students.Add(name);
        grades[name] = grade;

        Console.WriteLine($"\nStudent '{name}' added with grade: {grade}");
    }

    static void SearchStudent()
    {
        Console.WriteLine("\n--- Search Student ---");
        Console.Write("Enter name: ");
        string name = Console.ReadLine()?.Trim();

        if (grades.ContainsKey(name))
        {
            Console.WriteLine($"\nStudent:  {name}");
            Console.WriteLine($"   Grade:    {grades[name]}");
            Console.WriteLine($"   Rating:   {GetLetterGrade(grades[name])}");
        }
        else
        {
            Console.WriteLine("\nStudent not found");
        }
    }

    static void UpdateGrade()
    {
        Console.WriteLine("\n--- Update Grade ---");
        Console.Write("Enter student name: ");
        string name = Console.ReadLine()?.Trim();

        if (!grades.ContainsKey(name))
        {
            Console.WriteLine("\nStudent not found");
            return;
        }

        Console.WriteLine($"   Current grade: {grades[name]}");
        Console.Write("Enter new grade (0-100): ");

        if (!int.TryParse(Console.ReadLine(), out int newGrade) || newGrade < 0 || newGrade > 100)
        {
            Console.WriteLine("Grade must be a whole number between 0 and 100!");
            return;
        }

        int oldGrade = grades[name];
        grades[name] = newGrade;

        Console.WriteLine($"\n'{name}'s grade updated: {oldGrade} → {newGrade}");
    }

    static void ShowAllStudents()
    {
        Console.WriteLine("\n--- All Students ---");

        if (students.Count == 0)
        {
            Console.WriteLine("The list is empty. No students have been added.");
            return;
        }

        Console.WriteLine($"\n{"#",-4} {"Name",-20} {"Grade",-8} {"Rating",-10}");
        Console.WriteLine(new string('─', 44));

        for (int i = 0; i < students.Count; i++)
        {
            string name = students[i];
            int grade = grades[name];
            Console.WriteLine($"{i + 1,-4} {name,-20} {grade,-8} {GetLetterGrade(grade),-10}");
        }

        Console.WriteLine(new string('─', 44));
        Console.WriteLine($"Total students: {students.Count}");
    }

    static string GetLetterGrade(int grade)
    {
        return grade switch
        {
            >= 91 => "A (Excellent)",
            >= 81 => "B (Good)",
            >= 71 => "C (Average)",
            >= 61 => "D (Satisfactory)",
            _      => "F (Fail)"
        };
    }
}