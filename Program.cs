//-----------C# ASSIGNMENT 1 ----------------
//[1]Take 2 numbers from user and add them.

using C_Assignment1_19_01_2024.Interfaces;
using C_Assignment1_19_01_2024.Models;
using C_Assignment1_19_01_2024.Repository;
using System;
using System.Xml.Linq;

//float num1, num2;
//Console.WriteLine("Enter two numbers here");
//num1 = float.Parse(Console.ReadLine());
//num2 = float.Parse(Console.ReadLine());
//Console.WriteLine($"Addition of {num1} and {num2} is : {num1+num2}");

////2) Take 2 numbers from user and print the biggest

//Console.WriteLine("Enter the first number:");
//int n1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number:");
//int n2 = int.Parse(Console.ReadLine());

//int max = Math.Max(n1, n2);

//Console.WriteLine($"The biggest of {n1} and {n2} is: {max}");


////------------------------or way 2 ----------------------
//Console.WriteLine("WAY 2");
//if (n1 > n2)
//    Console.WriteLine($"The biggest of {n1} and {n2} is: {n1}");
//else
//    Console.WriteLine($"The biggest of {n1} and {n2} is: {n2}");



////3) Take a number from user and check if it is even

//int number;
//Console.WriteLine("Please enter a number to check if it is even or odd");
//number = int.Parse(Console.ReadLine());
//if (number % 2 == 0)
//    Console.WriteLine($"{number} is even number");
//else
//    Console.WriteLine($"{number} is odd number");

////---------way 2 :- Using Ternary operator 

//string result = (number % 2 == 0) ? $"{number} is even number" : $"{number} is odd number";
//Console.WriteLine(result);

////4) Take a number from user and find if it is prime or not

//Console.WriteLine("Enter a number:");
//int num = int.Parse(Console.ReadLine());

//bool isPrime = true;

//for (int i = 2; i <= Math.Sqrt(num); i++)
//{
//    if (num % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}

//if (isPrime && num > 1)
//{
//    Console.WriteLine($"{num} is a prime number.");
//}
//else
//{
//    Console.WriteLine($"{num} is not a prime number.");
//}

////5) Take a number from user and find its square

//Console.WriteLine("Enter a number to find its square:");
//int number1 = int.Parse(Console.ReadLine());

//int square = number1 * number1;

//Console.WriteLine($"The square of {number1} is: {square}");

////6) Take 10 numbers from user and find the average of them

//int sum = 0;

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"Enter number {i}:");
//    int number3 = int.Parse(Console.ReadLine());
//    sum += number3;
//}

//double average = (double)sum / 10;

//Console.WriteLine($"The average of the 10 numbers is: {average}");

////7) Create a layered application that will as of now do the CRUD for doctors

////Doctor properties -> Id, Name, Age, Qualification, Experience, Specialty

//namespace C__Assignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            IRepository<int, Doctor> DR = new DoctorRepository();

//            string ch = "y";

//            do
//            {
//                Console.WriteLine("\n 1.ADD A DOCTOR");
//                Console.WriteLine("\n 2.GET ALL DOCTORS");
//                Console.WriteLine("\n 3.GET DOC INFO BY ID");
//                Console.WriteLine("\n 4.UPDATE DOC INFO");
//                Console.WriteLine("\n 5.DELETE A DOCTOR");
//                Console.WriteLine("\n 6.EXIT");

//                int option = int.Parse(Console.ReadLine());

//                switch (option)
//                {
//                    case 1:
//                        var D1 = new Doctor();
//                        {
//                            Name = "Dr.Elena",
//                            Age = 30,
//                            Experience = 4.5f,
//                            Qualification = "MBBS",
//                            Speciality = "Cardiologist"

//                        };
//                        DR.Add(D1);
//                        break;

//                    case 2:
//                        int _id = 101;
//                        var D = DR.Get(_id);

//                        if (D != null)
//                        {
//                            D.Age = 31;
//                            var updated_doctor = DR.Update(D);
//                            if (updated_doctor != null)
//                            {
//                                Console.WriteLine($"Updated Doctor :: ID {updated_doctor.Id}, Name : {updated_doctor.Name});
//                            }
//                        }
//                        break;

//                    case 3:

//                        int DoctorIdToGet = 101;

//                        var retrieved_Doctor = DR.Get(DoctorIdToGet);

//                        if (retrieved_Doctor != null)
//                        {
//                            Console.WriteLine($"Retrieved Doctor: ID: {retrieved_Doctor.Id}, Name:{retrieved_Doctor.Name}, Experience: {retrieved_Doctor.Experience:C}");
//                        }

//                        break;

//                    case 4:

//                        var allDoctors = DR.GetAll();

//                        if (allDoctors != null)
//                        {
//                            Console.WriteLine("All Doctors:");
//                            foreach (var Doctor in allDoctors)
//                            {
//                                Console.WriteLine($"ID: {Doctor.Id}, Name: {Doctor.Name}, Experience:{Doctor.Experience:C}");
//                            }
//                        }
//                        break;

//                    case 5:

//                        int DoctorIdToDelete = 102;

//                        var deletedDoctor = DR.Delete(DoctorIdToDelete);

//                        if (deletedDoctor != null)
//                        {
//                            Console.WriteLine($"Deleted Doctor: ID: {deletedDoctor.Id}, Name:{deletedDoctor.Name}");
//                        }


//                        var remainingDoctors = DR.GetAll();

//                        if (remainingDoctors != null)
//                        {
//                            Console.WriteLine("Remaining Doctors:");
//                            foreach (var Doctor in remainingDoctors)
//                            {
//                                Console.WriteLine($"ID: {Doctor.Id}, Name: {Doctor.Name}, Experience:{Doctor.Experience:C}");
//                            }
//                        }

//                        break;


//                    case 6:
//                        // Exit the application
//                        Console.WriteLine("Thank you for using our application. Have a great day!");
//                        Environment.Exit(0);
//                        break;
//                }
//                // Ask the user if they want to return to the main menu
//                Console.WriteLine("\n\n\n\t\t\t\t\tDo you want the main menu ... ?? (y/n)");
//                ch = Console.ReadLine();
//                Console.Clear();
//            } while (ch == "y");
//        }


//    }
//}