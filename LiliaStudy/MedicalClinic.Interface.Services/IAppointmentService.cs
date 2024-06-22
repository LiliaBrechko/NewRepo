using MedicalClinic.Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services
{
    public interface IAppointmentService
    {
        int Create(CreateAppointmentDTO createAppointmentDTO);
        void Update(int id, UpdateAppointmentDTO updateAppointmentDTO);
        AppointmentDTO Get(int id);
        IEnumerable<AppointmentDTO> GetAll();
        void Delete(int id);
    }
}
