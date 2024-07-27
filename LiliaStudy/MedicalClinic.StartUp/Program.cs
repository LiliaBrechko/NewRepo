using MedicalClinic.Infrastructure;
using System;
using MedicalClinic.Models;
using MedicalClinic.Services;
using MedicalClinic.Repository;
using System.Security.Cryptography.X509Certificates;
using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;


public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection().RegisterRepositories().RegisterServices();
        var serviceprovider = services.BuildServiceProvider();

        

        IDoctorServices doctorService = serviceprovider.GetRequiredService<IDoctorServices>();
        IPatientService patientService = serviceprovider.GetRequiredService<IPatientService>();
        IAppointmentService appointmentService =serviceprovider.GetRequiredService<IAppointmentService>();
        IClinicService clinicService = serviceprovider.GetRequiredService<IClinicService>();
        


        var doctor = doctorService.Get(1);

        
       

        //new CreatePatientDTO {FirstName = "James", LastName = "Anderson", DateOfBirth = new DateOnly(1982, 11, 11), Gender = Gender.Male, PhoneNumber = "1231231234", Email = "james.anderson@example.com" },



        //doctorService.AddDoctors(new List<CreateDoctorDTO>
        //{
        //    new CreateDoctorDTO { FirstName = "John", LastName = "Smith", Specialization = DoctorType.Cardiology },
        //    new CreateDoctorDTO { FirstName = "Mary", LastName = "Johnson", Specialization = DoctorType.Dermatology },
        //    new CreateDoctorDTO { FirstName = "James", LastName = "Williams", Specialization = DoctorType.Endocrinology },
        //    new CreateDoctorDTO { FirstName = "Patricia", LastName = "Brown", Specialization = DoctorType.Gastroenterology },
        //    new CreateDoctorDTO { FirstName = "Robert", LastName = "Jones", Specialization = DoctorType.Hematology },
        //    new CreateDoctorDTO { FirstName = "Linda", LastName = "Miller", Specialization = DoctorType.Neurology },
        //    new CreateDoctorDTO { FirstName = "Michael", LastName = "Davis", Specialization = DoctorType.Oncology },
        //    new CreateDoctorDTO { FirstName = "Barbara", LastName = "Garcia", Specialization = DoctorType.Pediatrics },
        //    new CreateDoctorDTO { FirstName = "William", LastName = "Martinez", Specialization = DoctorType.Rheumatology },
        //    new CreateDoctorDTO { FirstName = "Elizabeth", LastName = "Rodriguez", Specialization = DoctorType.Urology }
        //});

    }
}




