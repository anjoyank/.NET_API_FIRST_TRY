using System.Collections.Generic;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data
{
    public interface IAircraftRepairRepo
    {
        IEnumerable<Aircraft> GetAircraftById(int id);

    }
}