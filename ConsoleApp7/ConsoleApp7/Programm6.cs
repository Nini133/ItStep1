// //დავალება 1 
// namespace ConsoleApp7;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[][] grades = {
//             new int[] { 85, 90, 78 },         // 1
//             new int[] { 70, 65, 80, 75 },  // 2
//             new int[] { 95, 88 },             // 3
//         };
//
//         for (int i = 0; i < grades.Length; i++)
//         {
//             double sum = 0;
//             foreach (int g in grades[i])
//                 sum += g;
//
//             double avg = sum / grades[i].Length;
//             Console.WriteLine($"სტუდენტი {i+1}: {avg:F2}");
//         }
//     }
// }

//
// //დავალება 2
//
// int[] passcodes = new int[10];
// Random rnd = new Random();
//
// for (int i = 0; i < passcodes.Length; i++)
//     passcodes[i] = rnd.Next(10000);
//
// Console.Write("Enter passcode: ");
// int input = int.Parse(Console.ReadLine());
//
// bool found = false;
// foreach (int code in passcodes)
// {
//     if (code == input)
//     {
//         found = true;
//         break;
//     }
// }
//
// Console.WriteLine(found ? "Correct" : "Wrong");

// //დავალება 3 
//
// int[] numbers = { -1, 2, -2, 3, 4,-10 , 200, 2003, -49 };
//
// int min = numbers[0];
// int max = numbers[0];
//
// foreach (int n in numbers)
// {
//     if (n < min) min = n;
//     if (n > max) max = n;
// }
//
// Console.WriteLine("Min: " + min);
// Console.WriteLine("Max: " + max);

// //დავალება 4 
//
// string[] words = { "ხინკალი", "ლუდი", "მწვადი" };
//
// for (int i = 0; i < words.Length; i++)
// {
//     for (int j = 0; j < words[i].Length; j++)
//     {
//         Console.WriteLine(words[i][j]);
//     }
// }

// //დავალება 5
//
// string[] emails = { "1@gmail.com", "ThisIsinvalidEmail", "testgmail.com", "wrongemail.com", "nnn@yahoo.com" };
//
// for (int i = 0; i < emails.Length; i++)
// {
//     bool hasAt = false;
//
//     for (int j = 0; j < emails[i].Length; j++)
//     {
//         if (emails[i][j] == '@')
//         {
//             hasAt = true;
//             break;
//         }
//     }
//
//     Console.WriteLine(emails[i] + ": " + (hasAt ? "Valid" : "Invalid"));
// }

