using AutoMapper;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Services
{
    public class AppointmentServices(IRepository<Patient> _patientRepository, IRepository<Doctor> _doctorRepository,
        IRepository<Appointment> _appointmentRepository, IMapper mapper) : IAppointmentService
    {
        public int Create(CreateAppointmentDTO createAppointmentDTO)
        {
            var appointment = mapper.Map<Appointment>(createAppointmentDTO);
            return _appointmentRepository.Create(appointment);
        }

        public void Delete(int id)
        {
            _appointmentRepository.Delete(id);
        }

        public AppointmentDTO Get(int id)
        {
            var currentappointment = _appointmentRepository.Get(a=> a.Id == id);
            return mapper.Map<AppointmentDTO>(currentappointment);
        }

        public IEnumerable<AppointmentDTO> GetAll()
        {
            return _appointmentRepository.GetAll().Select(mapper.Map<AppointmentDTO>);
            
        }

        public void Update(int id, UpdateAppointmentDTO updateAppointmentDTO)
        {
            var appointmenttoupdate = _appointmentRepository.Get(a=> a.Id == id);
            appointmenttoupdate.DoctorId = updateAppointmentDTO.DoctorId;
            appointmenttoupdate.AppointmentDate = updateAppointmentDTO.AppointmentDate;

            _appointmentRepository.Update(appointmenttoupdate);
        }
    }
}
