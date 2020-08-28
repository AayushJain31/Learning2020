using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientLibrary;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTraining1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAPIController : ControllerBase
    {
        private HospitalDbContext _hospitalDbContext = null;
        private readonly IMapper _mapper;
        public PatientAPIController(HospitalDbContext hospitalDb , IMapper mapper)
        {
            _hospitalDbContext = hospitalDb;
            _mapper = mapper;
        }

        // GET: api/<PatientAPIController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _hospitalDbContext.patients.Include(p => p.problems).ThenInclude(pt => pt.treatments).ToList();
        }

        // GET api/<PatientAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/PatientAPI>
        [HttpPost]
        public IActionResult Post([FromBody] PatientDTO objDTO)
        {
            Patient obj = new Patient();
            obj = _mapper.Map<Patient>(objDTO);
            var context = new System.ComponentModel.DataAnnotations.ValidationContext(obj, null, null);
            List<ValidationResult> errorResult = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, context, errorResult, true);
            if (isValid)
            {
                errorResult = new List<ValidationResult>();
                _hospitalDbContext.patients.Add(obj);
                _hospitalDbContext.SaveChanges();
                List<Patient> plist = _hospitalDbContext.patients.ToList<Patient>();
                return Ok(plist);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, errorResult);
            }
        }

        // PUT api/<PatientAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PatientDTO, Patient>(); // means you want to map from User to UserDTO
        }
    }

}
