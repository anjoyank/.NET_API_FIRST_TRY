using System;

namespace AirplaneAPI.Models
{
    public class AircraftRepair {
        public int AircraftId { get; set; }
        public Task[] Tasks { get; set; }
    }
}