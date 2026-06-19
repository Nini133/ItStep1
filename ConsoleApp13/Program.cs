using System;

class Program
{
    static Student[] students = new Student[100];
    static int count = 0;

    static void Add(Student s)
    {
        students[count] = s;
        count++;
    }

    static void LoadData()
    {
        Add(new Student("ნინო",   "რამიშვილი",       20, "nino@mail.ge",   "555-101", 85, Faculty.IT));
        Add(new Student("თეკლა",    "ოსეფაშვილი",   19, "tekla@mail.ge",   "555-102", 92, Faculty.Design));
        Add(new Student("ზურა",     "ქარჩავა",      22, "zura@mail.ge",    "555-103", 67, Faculty.Business));
        Add(new Student("ნათია",    "გოგიაშვილი",   21, "natia@mail.ge",   "555-104", 78, Faculty.Medicine));
        Add(new Student("გვანცა",   "ხუციშვილი",    18, "gvanca@mail.ge",  "555-105", 95, Faculty.IT));
        Add(new Student("ილია",     "ბარბაქაძე",    23, "ilia@mail.ge",    "555-106", 55, Faculty.Business));
        Add(new Student("ნუნუ",     "ჩხიკვაძე",     20, "nunu@mail.ge",    "555-107", 88, Faculty.Design));
        Add(new Student("მიხეილი",  "ყიფიანი",      24, "mikheil@mail.ge", "555-108", 72, Faculty.Medicine));
        Add(new Student("ეკა",      "ლომიძე",       19, "eka@mail.ge",     "555-109", 60, Faculty.IT));
        Add(new Student("სანდრო",   "ტყეშელაშვილი", 21, "sandro@mail.ge",  "555-110", 99, Faculty.Business));
    }

    static void ShowAll()
    {
        using (var log = new Logger())
        {
            log.Log("სტუდენტები");
            Console.WriteLine("\n სახელი გვარი            | ასაკი | ფაკ.      | GPA");
            Console.WriteLine("────");
            foreach (Student s in students)
            {
                if (s == null) break;
                s.ShowInfo();
            }
        }
    }

    static void BestStudent()
    {
        Student best = students[0];
        for (int i = 1; i < count; i++)
        {
            if (students[i] > best)
                best = students[i];
        }
        Console.WriteLine("\nსაუკეთესო სტუდენტი:");
        best.Print();
    }

    static void AverageGPA()
    {
        double total = 0;
        for (int i = 0; i < count; i++)
            total += students[i].GPA;
        Console.WriteLine($"\n საშუალო GPA: {total / count:F1}");
    }

    static void SearchByLastName()
    {
        Console.Write("\nგვარი: ");
        string input = Console.ReadLine().Trim().ToLower();
        bool found = false;

        foreach (Student s in students)
        {
            if (s == null) break;
            if (s.LastName.ToLower().Contains(input))
            {
                found = true;
                s.Print();
                Console.WriteLine("  ──────────────────");
            }
        }

        if (!found)
            Console.WriteLine(" სტუდენტი ვერ მოიძებნა.");
    }

    static void SortByGPA()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (students[j] < students[j + 1])
                {
                    Student tmp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = tmp;
                }
            }
        }
        Console.WriteLine("done");
        ShowAll();
    }

    static void AddStudent()
    {
        try
        {
            Console.Write("სახელი: ");
            string name = Console.ReadLine().Trim();

            Console.Write("გვარი: ");
            string lastName = Console.ReadLine().Trim();

            Console.Write("ასაკი: ");
            int age = int.Parse(Console.ReadLine());
            if (age <= 16) throw new Exception("ასაკი უნდა იყოს 16-ზე მეტი!");

            Console.Write("Email: ");
            string email = Console.ReadLine().Trim();
            if (!email.Contains("@")) throw new Exception("Email-ი არასწორია!");

            Console.Write("ტელ.: ");
            string phone = Console.ReadLine().Trim();

            Console.Write("GPA (0-100): ");
            double gpa = double.Parse(Console.ReadLine());
            if (gpa < 0 || gpa > 100) throw new Exception("GPA უნდა იყოს 0-დან 100-მდე!");

            Console.WriteLine("ფაკ.: 0=IT  1=Business  2=Design  3=Medicine");
            Console.Write("აირჩიეთ: ");
            int f = int.Parse(Console.ReadLine());
            if (f < 0 || f > 3) throw new Exception("ფაკულტეტი არასწორია!");

            Add(new Student(name, lastName, age, email, phone, gpa, (Faculty)f));
            Console.WriteLine("სტუდენტი დაემატა!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"შეცდომა: {ex.Message}");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("\nEmail: ");
        string email = Console.ReadLine().Trim().ToLower();
        int idx = -1;

        for (int i = 0; i < count; i++)
        {
            if (students[i].Email.ToLower() == email)
            {
                idx = i;
                break;
            }
        }

        if (idx == -1)
        {
            Console.WriteLine("ვერ მოიძებნა.");
            return;
        }

        for (int i = idx; i < count - 1; i++)
            students[i] = students[i + 1];

        students[count - 1] = null;
        count--;

        Console.WriteLine(" სტუდენტი წაიშალა!");
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        LoadData();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n══════════════════════════");
            Console.WriteLine("  1. სტუდენტების სია");
            Console.WriteLine("  2. საუკეთესო სტუდენტი");
            Console.WriteLine("  3. GPA საშუალო");
            Console.WriteLine("  4. ძებნა გვარით");
            Console.WriteLine("  5. დალაგება GPA-ით");
            Console.WriteLine("  6. სტუდენტის დამატება");
            Console.WriteLine("  7. სტუდენტის წაშლა");
            Console.WriteLine("  8. გასვლა");
            Console.WriteLine("══════════════════════════");
            Console.Write("→ ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1": ShowAll();          break;
                case "2": BestStudent();      break;
                case "3": AverageGPA();       break;
                case "4": SearchByLastName(); break;
                case "5": SortByGPA();        break;
                case "6": AddStudent();       break;
                case "7": DeleteStudent();    break;
                case "8": running = false;    break;
                default:  Console.WriteLine("არასწორი არჩევანი."); break;
            }
        }

        Console.WriteLine("პროგრამა დაიხურა.");
    }
}
