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
        IRepository<Appointment> _appointmentRepository) : IPatientService
    {

        public int Create(CreatePatientDTO createPatientDTO)
        {
            var patient = new Patient()
            {
                FirstName = createPatientDTO.FirstName,
                LastName = createPatientDTO.LastName,
                DateOfBirth = createPatientDTO.DateOfBirth,
                Gender = createPatientDTO.Gender,
                Email = createPatientDTO.Email,               
                PhoneNumber = createPatientDTO.PhoneNumber,
            };
            return _patientRepository.Create(patient);  
        }

        public void AddPatients(IEnumerable<CreatePatientDTO> patients)
        {
            foreach(var createPatientDTO in patients)
            {
                var patient = new Patient()
                {
                    FirstName = createPatientDTO.FirstName,
                    LastName = createPatientDTO.LastName,
                    DateOfBirth = createPatientDTO.DateOfBirth,
                    Gender = createPatientDTO.Gender,
                    Email = createPatientDTO.Email,
                    PhoneNumber = createPatientDTO.PhoneNumber,
                };
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
            var patientDTO = new PatientDTO()
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                DateOfBirth = patient.DateOfBirth,
                Gender = patient.Gender,
                Email = patient.Email,
                PhoneNumber = patient.PhoneNumber

            };
            return patientDTO;
        }

        public IEnumerable<PatientDTO> GetAll()
        {
            return _patientRepository.GetAll().Select(x => new PatientDTO()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth,
                Gender = x.Gender,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
            });
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
