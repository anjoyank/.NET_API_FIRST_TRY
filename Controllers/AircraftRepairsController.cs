using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AirplaneAPI.Models;
using AirplaneAPI.Data;
namespace AirplaneAPI.Controllers
{
    //should inherit from controller class if using View component
    [Route ("/aircraft/{aircraftId}/duelist")]
    [ApiController]
    public class AircraftRepairsController : ControllerBase
    {
        private readonly MockAircraftRepairRepo _repository = new MockAircraftRepairRepo();
        [HttpPost]
        public ActionResult <IEnumerable<Task>> ComputeTasksDue(int aircraftId) 
        {

        }
    }
}