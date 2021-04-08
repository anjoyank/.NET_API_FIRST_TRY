using System;
using System.Collections.Generic;

namespace AirplaneAPI.Models
{
    public class AircraftRepair {
        public int AircraftId { get; set; }
        public List<Repair> Repairs { get; set; }
    }
}