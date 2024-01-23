using C_Assignment1_19_01_2024.Interfaces;
using C_Assignment1_19_01_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment1_19_01_2024.Repository
{
    /// <summary>
    /// Implementation of interface (IRepository) for Doctor Model
    /// </summary>
    public class DoctorRepository : IRepository<int, Doctor>
    {
        /// <summary>
        /// List to Doctor entities
        /// </summary>
        List<Doctor> doctors;
        /// <summary>
        /// Constructor to initialize the DoctorReository
        /// </summary>
        public DoctorRepository()
        {
            doctors = new List<Doctor>();
        }

        /// <summary>
        /// Generates a unique id for a new doctor
        /// </summary>
        /// <returns>Returns generated id</returns>

        int GenerateID()
        {
            if(doctors.Count == 0)
            {
                //If no Doctors are present , start with ID 101
                return 101;
            }

            //else Get the ID of last doctor and increment for a new one 

            int id = doctors[doctors.Count - 1].Id;
            return ++id;

        }

        /// <summary>
        /// Adds a new Doctor to the repository
        /// </summary>
        /// <param name="doctor">Doctor obj to be added</param>
        /// <returns>Returns added doctor entity , or null if already present</returns>
        public Doctor? Add(Doctor doctor)
        {
            //Generating unique id for new doctor
            doctor.Id = GenerateID();
            //check if doctor is already present 
            if (doctors.Contains(doctor))
            {
                Console.WriteLine("Cannot Insert , Doctor already present");
                return null;
            }
            //Else : Add new doctor to repository
            else
            {
                doctors.Add(doctor);
                Console.WriteLine("Doctor added successfully");
                return doctor;
            }
            
            
        }

        /// <summary>
        /// Deletes a doctor from repository based on id 
        /// </summary>
        /// <param name="id">ID of doctor to be deleted</param>
        /// <returns>Returns Deleted Doctor entity if present , otherwise null </returns>

        public Doctor? Delete(int id)
        {
            //Get doctor by id
            var doctor = Get(id);
            //If : found --> remove doctor item from repository
            if (doctor != null)
            {
                doctors.Remove(doctor);
                return doctor;
            }
            //Else : return null with a msg
            Console.WriteLine("No doctor with given id is present to be removed");
            return null;
        }

        /// <summary>
        /// Retrieves a doctor from repository based on id
        /// </summary>
        /// <param name="id">The id of doctor to be retrieved</param>
        /// <returns>Returns retrieved doc , otherwise null</returns>

        public Doctor? Get(int id)
        {
            var doctor = doctors.SingleOrDefault(p => p.Id == id);
            return doctor;
        }

        /// <summary>
        /// Retrieves all the doctors presnet in repo
        /// </summary>
        /// <returns>A list of doctors if present , otherwise null</returns>

        public List<Doctor> GetAll()
        {
            if(doctors.Count == 0)
            {
                Console.WriteLine("No Doctors available");
                return null; 
            }
            return doctors;
        }

        /// <summary>
        /// Updates a doctor in repository 
        /// </summary>
        /// <param name="doctor">The doctor obj to be updated</param>
        /// <returns>Returns updated doctor if presnt , otherwise null</returns>

        public Doctor? Update(Doctor doctor)
        {
            var myDoctor = Get(doctor.Id);
            if(myDoctor != null)
            {
                myDoctor = MapDoctor(doctor);
                return myDoctor;
            }

            Console.WriteLine("No Doctor with given id is present to be updated");
            return null;
        }
        /// <summary>
        /// Maps properties from one doctor entity to another
        /// </summary>
        /// <param name="doctor">The source doctor entity</param>
        /// <returns>A new doctor entity with same props as source</returns>

        Doctor MapDoctor(Doctor doctor)
        {
            Doctor myDoctor = new Doctor();
            myDoctor.Id = doctor.Id;
            myDoctor.Name = doctor.Name;
            myDoctor.Age = doctor.Age;
            myDoctor.Qualification = doctor.Qualification;
            myDoctor.Experience = doctor.Experience;
            myDoctor.Speciality= doctor.Speciality;
            return myDoctor;
        }
    }
}
