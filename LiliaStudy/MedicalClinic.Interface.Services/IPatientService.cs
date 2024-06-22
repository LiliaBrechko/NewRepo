using MedicalClinic.Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services
{
    public interface IPatientService
    {
        int Create(CreatePatientDTO createPatientDTO);
        void Update(int id, UpdatePatientDTO updatePatientDTO);
        PatientDTO Get(int id);
        IEnumerable<PatientDTO> GetAll();
        void Delete(int id);
    }
}
