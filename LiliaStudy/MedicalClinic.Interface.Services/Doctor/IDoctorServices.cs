
using MedicalClinic.Interface.Services.DTO;

namespace MedicalClinic.Interface.Services
{
    public interface IDoctorServices
    {
        int Create(CreateDoctorDTO createDoctorDTO);
        void Update(int id, UpdateDoctorDTO updateDoctorDTO);
        DoctorDTO Get(int id);
        IEnumerable<DoctorDTO> GetAll();
        void Delete(int id);

        IEnumerable<ConclusionDTO> GetAllConclusion(int doctorId, int patientId);

    }
}
