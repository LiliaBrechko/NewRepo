using MedicalClinic.Interface.Services.DTO;
using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services
{
    public interface IClinicService
    {
        int CreateAppointment(int? patientId, string reason, DoctorType doctorType, DateTime dateTime);
        void UpdateAppointment(int appointmentId, UpdateAppointmentDTO updateAppointmentDTO);
        void CancelAppointment(int appointmentId);
        
    }
}
