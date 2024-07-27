using AutoMapper;
using MedicalClinic.Interface.Services.DTO;
using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorDTO>();
            CreateMap<Doctor, CreateDoctorDTO>();
            CreateMap<Doctor, UpdateDoctorDTO>();

            CreateMap<Appointment, AppointmentDTO>();
            CreateMap<Appointment, CreateAppointmentDTO>();
            CreateMap<Appointment, UpdateAppointmentDTO>();

            CreateMap<Patient, CreatePatientDTO>();
            CreateMap<Patient, CreatePatientDTO>();
            CreateMap<Patient, CreatePatientDTO>();
        }
    }
}
