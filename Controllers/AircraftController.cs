using System.Collections.Generic;
using AirplaneAPI.Data;
using AirplaneAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirplaneAPI.Controllers
{
    [Route("/aircraft")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly IAircraftRepairRepo _repository;

        public AircraftController(IAircraftRepairRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockAircraftRepairRepo _repository = new MockAircraftRepairRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Aircraft>> GetEveryAircraft()
        {
            var aircraftItems = _repository.GetAllAircraft();
            return Ok(aircraftItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Aircraft> GetOneAircraft(int id)
        {
            var aircraftItem = _repository.GetAircraftById(id);
            return Ok(aircraftItem);
        }
    }
    
}