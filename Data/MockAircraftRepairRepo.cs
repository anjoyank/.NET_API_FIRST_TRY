// using System.Collections.Generic;
// using AirplaneAPI.Models;

// namespace AirplaneAPI.Data
// {
//     public class MockAircraftRepairRepo : IAircraftRepairRepo
//     {
//         public IEnumerable<Aircraft> GetAllAircraft()
//         {
//             var aircraftAll = new List<Aircraft>
//             {
//                 new Aircraft{AircraftId=1, DailyHours=0.7, CurrentHours=550},
//                 new Aircraft{AircraftId=2, DailyHours=1.1, CurrentHours=200}
//             };
//             return aircraftAll;
//         }

//         public Aircraft GetAircraftById(int id)
//         {
//             return new Aircraft{AircraftId=1, DailyHours=0.7, CurrentHours=550};
//         }

//         public AircraftRepair CreateAircraftRepair(Repair[] repairs, int id)
//         {
//             throw new System.NotImplementedException();
//         }

//     }
// }