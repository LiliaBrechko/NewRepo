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
    public class PatientService(IRepository<Patient> _patientRepository, IRepository<Doctor> _doctorRepository,
        IRepository<Appointment> _appointmentRepository, IMapper mapper) : IPatientService
    {

        public int Create(CreatePatientDTO createPatientDTO)
        {
            var patient = mapper.Map<Patient>(createPatientDTO);
            return _patientRepository.Create(patient);  
        }

        public void AddPatients(IEnumerable<CreatePatientDTO> patients)
        {
            foreach(var createPatientDTO in patients)
            {
                var patient = mapper.Map<Patient>(createPatientDTO);
                _patientRepository.Create(patient);

            }
        }

        public void Delete(int id)
        {
            _patientRepository.Delete(id);
        }

        public PatientDTO Get(int id)
        {
            var patient = _patientRepository.Get(p => p.Id == id);
            
            return mapper.Map<PatientDTO>(patient);
        }

        public IEnumerable<PatientDTO> GetAll()
        {
            return _patientRepository.GetAll().Select(mapper.Map<PatientDTO>);
        }

        public void Update(int id, UpdatePatientDTO updatePatientDTO)
        {
            var patientToUpdate = _patientRepository.Get(p => p.Id == id);
            patientToUpdate.FirstName = updatePatientDTO.FirstName;
            patientToUpdate.LastName = updatePatientDTO.LastName;
            patientToUpdate.PhoneNumber = updatePatientDTO.PhoneNumber;
            patientToUpdate.Gender = updatePatientDTO.Gender;
            patientToUpdate.Email = updatePatientDTO.Email;
            
            _patientRepository.Update(patientToUpdate);
        }
    }
}
