using System.Collections.Generic;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data
{
    public interface IAircraftRepairRepo
    {
        //this is actually a POST operation
        //will finish this after implementing GETs
        AircraftRepair CreateAircraftRepair(Task[] repairs, int id);

        //2 GET endpoints for practice
        IEnumerable<Aircraft> GetAllAircraft();
        Aircraft GetAircraftById(int id);



    }
}