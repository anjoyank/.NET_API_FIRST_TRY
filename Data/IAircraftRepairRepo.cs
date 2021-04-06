using System.Collections.Generic;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data
{
    public interface IAircraftRepairRepo
    {
        IEnumerable<Aircraft> GetAllAircraft();
        Aircraft GetAircraftById(int id);

        IEnumerable<Task> GetAllTasks();

        Task GetTaskById(int id);

        AircraftRepair GetAircraftRepairById(int id);

    }
}