using MedicalClinic.Interface.Services;
using MedicalClinic.Interface.Services.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MedicalClinic.WebApi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {
       

        private readonly ILogger<DoctorController> _logger;
        private readonly IDoctorServices _doctorServices;

        public DoctorController(ILogger<DoctorController> logger, IDoctorServices doctorServices)
        {
            _logger = logger;
            _doctorServices = doctorServices;
        }

        [HttpGet, Route("{id}")]
        public DoctorDTO Get(int id)
        {
            return _doctorServices.Get(id);
        }

        [HttpGet, Route("")]
        public IEnumerable<DoctorDTO> GetAll()
        {
            return _doctorServices.GetAll();
        }

        [HttpPost, Route("")]
        public int Create([FromBody] CreateDoctorDTO createDoctorDTO)
        {
            return _doctorServices.Create(createDoctorDTO);
        }

        [HttpPut, Route("{id}")]
        public void Update([FromRoute] int id, [FromBody] UpdateDoctorDTO updateDoctorDTO)
        {
             _doctorServices.Update(id, updateDoctorDTO);
        }

        [HttpDelete, Route("{id}")]
        public void Delete([FromRoute] int id)
        {
            _doctorServices.Delete(id);
        }

    }
}
