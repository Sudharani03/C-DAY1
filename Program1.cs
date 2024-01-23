using C_Assignment1_19_01_2024.Interfaces;
using C_Assignment1_19_01_2024.Models;
using C_Assignment1_19_01_2024.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment1_19_01_2024
{
    public class Program1 
    {
        
        static void Main(String[] args)
        {
            // Instance of DoctorRepository implementing interface repository
            IRepository<int, Doctor> DR = new DoctorRepository();

            while(true)
            {
                Console.WriteLine("\n 1.ADD A DOCTOR");
                Console.WriteLine("\n 2.GET ALL DOCTORS");
                Console.WriteLine("\n 3.UPDATE DOC INFO");
                Console.WriteLine("\n 4.DELETE A DOCTOR");
                Console.WriteLine("\n 5.EXIT");

                int option = int.Parse(Console.ReadLine());



                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Name");
                        string enteredName = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        int enteredAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Qualification");
                        string enteredQualification = Console.ReadLine();
                        Console.WriteLine("Enter Experience");
                        float enteredExperience = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Specialization");
                        string enteredSpeciality = Console.ReadLine();
                        Doctor newDoctor = new Doctor
                        {
                            Name = enteredName,
                            Age = enteredAge,
                            Qualification = enteredQualification,
                            Experience = enteredExperience,
                            Speciality = enteredSpeciality
                        };
                        DR.Add(newDoctor);
                        break;

                    case 2:
                        Console.WriteLine("All Doctors:");
                        foreach (var doctor in DR.GetAll())
                        {
                            Console.WriteLine(doctor);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter id of doctor to update the details");
                        int enteredIdToUpdate = int.Parse(Console.ReadLine());
                        var existingDoctor = DR.GetAll().FirstOrDefault(d => d.Id == enteredIdToUpdate);
                        if (existingDoctor != null)
                        {
                            Console.WriteLine("Enter Name");
                            string enteredUpdateName = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            int enteredUpdateAge = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Qualification");
                            string enteredUpdateQualification = Console.ReadLine();
                            Console.WriteLine("Enter Experience");
                            int enteredUpdateExperience = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Specialization");
                            string enteredUpdateSpeciality = Console.ReadLine();
                            Doctor updatedDoctor = new Doctor
                            {
                                Id = enteredIdToUpdate,
                                Name = enteredUpdateName,
                                Age = enteredUpdateAge,
                                Qualification = enteredUpdateQualification,
                                Experience = enteredUpdateExperience,
                                Speciality = enteredUpdateSpeciality
                            };
                            DR.Update(updatedDoctor);
                        }
                        else
                        {
                            Console.WriteLine($"No doctor with ID {enteredIdToUpdate} found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the id to delete that record");
                        int doctorIdToDelete = int.Parse(Console.ReadLine());
                        DR.Delete(doctorIdToDelete);
                        break;
                    case 5:
                        // Exit the application
                        Console.WriteLine("Thank you for using our application. Have a great day!");
                        Environment.Exit(0);
                        break;
                }
               
            }
            
        }
    }
}
