using FluentAssertions;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using MedicalClinic.Models;
using MedicalClinic.Repository;
using MedicalClinic.Services;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MedicalClinic.Integration.Tests
{
    public class AppointmentServiceTests
    {
        private IPatientService patientService;
        private IDoctorServices doctorServices;
        private IAppointmentService appointmentService;
        private IRepository<Appointment> appointmentRepository;

        public AppointmentServiceTests()
        {
            var services = new ServiceCollection().RegisterRepositories().RegisterServices();
            var serviceProvider = services.BuildServiceProvider();
            patientService = serviceProvider.GetService<IPatientService>();
            doctorServices = serviceProvider.GetService<IDoctorServices>();
            appointmentService = serviceProvider.GetService<IAppointmentService>();
            appointmentRepository = serviceProvider.GetService<IRepository<Appointment>>();
        }

        [Fact]
        public void CreateAppointmentIsSuccessful()
        {
            //arrange
            var createPatientDTO = new CreatePatientDTO() { DateOfBirth = new DateOnly(1992, 10, 9), FirstName = "Lilia", LastName = "Brechko", Gender = Models.Gender.Male };
            var patientId = patientService.Create(createPatientDTO);
            var createDoctorDTO = new CreateDoctorDTO() { FirstName = "Olga", LastName = "Savytska", Specialization = Models.DoctorType.Rheumatology };
            var doctorId= doctorServices.Create(createDoctorDTO);

            var createAppointmentDTO = new CreateAppointmentDTO() { AppointmentDate = DateTime.Now , PatientId = patientId, DoctorId = doctorId};

            //act
            var appointmentID = appointmentService.Create(createAppointmentDTO);

            //assert
            var appointment = appointmentRepository.Get(x => x.Id == appointmentID);
            appointment.AppointmentDate.Should().Be(createAppointmentDTO.AppointmentDate);
            appointment.DoctorId.Should().Be(doctorId);
            appointment.PatientId.Should().Be(patientId);
        }

    }
}
