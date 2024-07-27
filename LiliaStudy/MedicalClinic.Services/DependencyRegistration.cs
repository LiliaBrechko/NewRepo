using AutoMapper;
using MedicalClinic.Interface.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Services
{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection collection)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            IMapper mapper = config.CreateMapper();

            collection.AddTransient<IDoctorServices,DoctorService>();
            collection.AddTransient<IPatientService, PatientService>();
            collection.AddTransient<IClinicService, ClinicService>();
            collection.AddTransient<IAppointmentService, AppointmentServices>();
            collection.AddSingleton<IMapper>(mapper);

            return collection;
        }
    }
}
