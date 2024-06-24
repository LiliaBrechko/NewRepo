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
    public class ClinicService(IRepository<Doctor> _doctorRepository, IAppointmentService _appointmentService ) : IClinicService
    {
        public int CreateAppointment(int? patientId, string reason, DoctorType doctorType, DateTime dateTime)
        {
            if( patientId == null )
            {
                throw new ArgumentNullException("Patient not found. You have to add new patient at first");
            }
            
            var availabledoctor = _doctorRepository.GetAll().FirstOrDefault(d => d.Specialization == doctorType);
         
            var appointment = new CreateAppointmentDTO
            {
                PatientId = (int)patientId,
                Reason = reason,
                DoctorId = availabledoctor.Id,
                AppointmentDate = dateTime,
            };



            return _appointmentService.Create(appointment);

            
        }

        public void CancelAppointment(int appointmentId)
        {
            _appointmentService.Delete(appointmentId);
        }

        public void UpdateAppointment(int appointmentId, UpdateAppointmentDTO updateAppointmentDTO)
        {
            _appointmentService.Update(appointmentId, updateAppointmentDTO);


        }
    }
}
