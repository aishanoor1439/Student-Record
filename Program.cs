using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\ABC\\Desktop\\Students.txt";
            Console.WriteLine("Welcome to the Student Information Program!");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine($"\nEnter details for Student {i}:");

                        Console.Write("Student ID: ");
                        string studentId = Console.ReadLine();

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Date of Birth (dd/MM/yyyy): ");
                        string dob = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Residential Address: ");
                        string address = Console.ReadLine();

                        Console.Write("Job Title: ");
                        string jobTitle = Console.ReadLine();

                        Console.Write("Salary: ");
                        string salary = Console.ReadLine();

                        writer.WriteLine($"Student {i}:");
                        writer.WriteLine($"ID: {studentId}");
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Date of Birth: {dob}");
                        writer.WriteLine($"Email: {email}");
                        writer.WriteLine($"Address: {address}");
                        writer.WriteLine($"Job Title: {jobTitle}");
                        writer.WriteLine($"Salary: {salary}");
                        writer.WriteLine(new string('-', 40));
                    }
                }

                Console.WriteLine("\nAll student records have been successfully saved to 'Students.txt'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
