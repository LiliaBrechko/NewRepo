using AutoMapper;
using MedicalClinic.Interface.Repository;
using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using MedicalClinic.Models;

namespace MedicalClinic.Services
{
    public class DoctorService(IRepository<Patient> _patientRepository, IRepository<Doctor> _doctorRepository,
        IRepository<Appointment> _appointmentRepository, IRepository<Conclusion> _conclusionRepository, IMapper mapper) : IDoctorServices
    {
        public int Create(CreateDoctorDTO createDoctorDTO)
        {
            var doctor = mapper.Map<Doctor>(createDoctorDTO);
            return _doctorRepository.Create(doctor);
        }

        public  void AddDoctors(IEnumerable<CreateDoctorDTO> addDoctorsDTO)
        {
            foreach (var doctordto in addDoctorsDTO)
            {
                var doctor = mapper.Map<Doctor>(doctordto);
                _doctorRepository.Create(doctor);
            }
            
        }

        public void Delete(int id)
        {
            _doctorRepository.Delete(id);
        }

        public DoctorDTO Get(int id)
        {
            var currentDoctor = _doctorRepository.Get(x => x.Id == id, x=>x.Appointments);
            return mapper.Map<DoctorDTO>(currentDoctor);
           
        }

        public IEnumerable<DoctorDTO> GetAll()
        {
            return _doctorRepository.GetAll().Select(mapper.Map<DoctorDTO>);
        }

        public IEnumerable<ConclusionDTO> GetAllConclusion(int doctorId, int patientId)
        {
            var appointments = _doctorRepository.Get(x => x.Id == doctorId, d => d.Appointments).Appointments
                .Where(a => a.PatientId == patientId);

            foreach (var appointment in appointments)
            {
                var conclusion = _conclusionRepository.Get(c => c.AppoinmentId == appointment.Id);
                yield return new ConclusionDTO
                {
                    Id = conclusion.Id,
                    Recomendation = conclusion.Recomendation,
                    Appoinment = new AppointmentDTO
                    {
                        Id = appointment.Id,
                        AppointmentDate = appointment.AppointmentDate,
                        DoctorId = appointment.DoctorId,
                        PatientId = appointment.PatientId,
                        Reason = appointment.Reason
                    }
                };
            }
        }

        public void Update(int id, UpdateDoctorDTO updateDoctorDTO)
        {
            var doctorToUpdate = _doctorRepository.Get(d => d.Id == id);
            doctorToUpdate.Specialization = updateDoctorDTO.Specialization;
            doctorToUpdate.LastName = updateDoctorDTO.LastName;
            _doctorRepository.Update(doctorToUpdate);
        }
    }
}
