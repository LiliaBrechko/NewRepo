using MedicalClinic.Infrastructure;
using System;
using MedicalClinic.Models;
using MedicalClinic.Services;
using MedicalClinic.Repository;
using System.Security.Cryptography.X509Certificates;
using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;


public class Program
{
    public static void Main(string[] args)
    {
        Repository<Doctor> _doctorsrepository = new Repository<Doctor>();
        Repository<Patient> _patientsrepository = new Repository<Patient>();
        Repository<Appointment> _appointmentsrepository = new Repository<Appointment>();
        Repository<Conclusion> _conclusionrepository = new Repository<Conclusion>();

        DoctorService doctorService = new DoctorService(_patientsrepository, _doctorsrepository, _appointmentsrepository, _conclusionrepository);
        PatientService patientService = new PatientService(_patientsrepository, _doctorsrepository, _appointmentsrepository);
        AppointmentServices appointmentService = new AppointmentServices(_patientsrepository, _doctorsrepository, _appointmentsrepository);
        ClinicService clinicService = new ClinicService(_doctorsrepository, appointmentService);





        var val = _appointmentsrepository.GetAll(x => x.Patient, x => x.Doctor).ToList();
        var concreteAppointment = _appointmentsrepository.Get(x => x.Patient.Id == 1, x => x.Doctor);

        var concreteAppointment1 = _appointmentsrepository.GetProjected(x => x.Patient.Id == 1, x => new {x.Doctor.FirstName, x.Doctor.LastName });

       

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




