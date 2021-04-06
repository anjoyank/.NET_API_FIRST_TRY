using System.Collections.Generic;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data
{
    public class MockAircraftRepo : IAircraftRepairRepo
    {
                IEnumerable<Aircraft> GetAircraftById(int id);

    }
}