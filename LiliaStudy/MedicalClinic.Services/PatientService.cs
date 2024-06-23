using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Services
{
    public class PatientService : IPatientService
    {
        public int Create(CreatePatientDTO createPatientDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PatientDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, UpdatePatientDTO updatePatientDTO)
        {
            throw new NotImplementedException();
        }
    }
}
