using AutoMapper;
using FluentAssertions;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Interface.Services;
using MedicalClinic.Models;
using MedicalClinic.Services;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Linq.Expressions;
using Xunit;

namespace MedicalClinic.Unit.Tests
{
    public class DoctorServiceTests
    {
        private IDoctorServices doctorServices;
        private Mock<IRepository<Doctor>> doctorRepositoryMock;


        public DoctorServiceTests()
        {
            var services = new ServiceCollection().RegisterServices();
            var serviceProvider = services.BuildServiceProvider();

            doctorRepositoryMock = new Mock<IRepository<Doctor>>();
            doctorServices = new DoctorService(new Mock<IRepository<Patient>>().Object, doctorRepositoryMock.Object, new Mock<IRepository<Appointment>>().Object,
                new Mock<IRepository<Conclusion>>().Object, serviceProvider.GetService<IMapper>());
        }

        [Fact]
        public void UpdateDoctorDifferentSpecializationThrowsExactError()
        {
            //arrange
            var doctor = new Doctor { FirstName = "", Specialization = DoctorType.Neurology };

            doctorRepositoryMock.Setup(x => x.Get(
                It.IsAny<Expression<Func<Doctor, bool>>>(),
                It.IsAny<Expression<Func<Doctor, object>>[]>())).Returns(doctor);

            //act
            var action = () => doctorServices.Update(1, new Interface.Services.DTO.UpdateDoctorDTO
            {
                LastName = "",
                Specialization = DoctorType.Pediatrics
            });

            //assert
            action.Should().Throw<Exception>().WithMessage("wrong");
        }
    }
}
