using System.Collections.Generic;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data
{
    public class MockAircraftRepo : IAircraftRepairRepo
    {
        public AircraftRepair GetAircraftRepairById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Aircraft> GetAllAircraft()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Task> GetAllTasks()
        {
            throw new System.NotImplementedException();
        }

        public Task GetTaskById(int id)
        {
            throw new System.NotImplementedException();
        }


        Aircraft IAircraftRepairRepo.GetAircraftById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}