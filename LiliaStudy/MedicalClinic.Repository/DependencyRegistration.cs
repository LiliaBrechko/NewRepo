using MedicalClinic.Interface.Repository;
using MedicalClinic.Interface.Services;
using MedicalClinic.Models;
using MedicalClinic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Repository

{
    public static class DependencyRegistration
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection collection)
        {
            collection.AddTransient<IRepository<Doctor>, Repository<Doctor>>();
            collection.AddTransient<IRepository<Patient>, Repository<Patient>>();
            collection.AddTransient<IRepository<Appointment>, Repository<Appointment>>();
            collection.AddTransient<IRepository<Conclusion>, Repository<Conclusion>>();

            return collection;
        }
    }
}
