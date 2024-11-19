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
            CreateMap<CreateDoctorDTO,Doctor>();
            CreateMap<UpdateDoctorDTO,Doctor>();

            CreateMap<Appointment, AppointmentDTO>();
            CreateMap<CreateAppointmentDTO, Appointment>();
            CreateMap<UpdateAppointmentDTO, Appointment>();

            CreateMap<Patient, PatientDTO>();
            CreateMap<CreatePatientDTO, Patient>();
            CreateMap<UpdatePatientDTO, Patient>();
        }
    }
}
