using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirplaneAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace AirplaneAPI.Controllers
{
    [Route("[Controller]/{id}/duelist")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly MyContext _context;

        public AircraftController(MyContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<AircraftRepair> CreateTasksDue(Repair[] repairs, int id) 
        {
            var aircraftList = new List<Aircraft>
            {
                new Aircraft{AircraftId=1, DailyHours=0.7, CurrentHours=550},
                new Aircraft{AircraftId=2, DailyHours=1.1, CurrentHours=200}
            };
            var thisAircraft = aircraftList.Find(p => p.AircraftId == id);
            
            var nextDueList = new List<Repair>();
            foreach (Repair repair in repairs)
            {
                DateTime logDate = repair.LogDate;
                double? DaysRemainingByHoursInterval;
                DateTime? IntervalHoursNextDueDate = null;
                DateTime? IntervalMonthsNextDueDate = null;
                if (repair.IntervalMonths != null && repair.LogDate != null)
                {
                    IntervalMonthsNextDueDate = logDate.AddMonths((int)repair.IntervalMonths);
                }
                
                if (repair.LogHours != null && repair.IntervalHours != null)
                {
                    DaysRemainingByHoursInterval = (((repair.LogHours + repair.IntervalHours) - thisAircraft.CurrentHours) / thisAircraft.DailyHours);
                    IntervalHoursNextDueDate = logDate.AddDays((double)DaysRemainingByHoursInterval);
                }

                if (IntervalHoursNextDueDate <= IntervalMonthsNextDueDate || IntervalMonthsNextDueDate == null)
                {
                    repair.NextDue = IntervalHoursNextDueDate;
                }
                
                else
                {
                    repair.NextDue = IntervalMonthsNextDueDate;
                }

                nextDueList.Add(repair);
            }

            var repairsDue = new AircraftRepair{AircraftId = id, Repairs = nextDueList};
            _context.AircraftRepairDbSet.Add(repairsDue);
            _context.SaveChanges();
            return repairsDue;
        }
    }

//  [
//  {
//  "ItemNumber": "1",
//  "Description": "Item 1",
//  "LogDate": "2018-04-07T00:00:00",
//  "LogHours": null,
//  "IntervalMonths": null,
//  "IntervalHours": null
//  },
//  {
//  "ItemNumber": "2",
//  "Description": "Item 2",
//  "LogDate": "2018-04-07T00:00:00",
//  "LogHours": "100",
//  "IntervalMonths": "12",
//  "IntervalHours": "500"
//  },
//  {
//  "ItemNumber": "3",
//  "Description": "Item 3",
//  "LogDate": "2018-06-01T00:00:00",
//  "LogHours": "150",
//  "IntervalMonths": null,
//  "IntervalHours": "400"
//  },
//  {
//  "ItemNumber": "4",
//  "Description": "Item 4",
//  "LogDate": "2018-06-01T00:00:00",
//  "LogHours": "150",
//  "IntervalMonths": "6",
//  "IntervalHours": null
//  }
//  ]
    
}