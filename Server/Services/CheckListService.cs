using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class CheckListService
    {
        public static FMSDailyCheckListVM DailyMorningCheckListToViewModel(FMSDailyMorning dailyMorning)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.VehicleNumber = dailyMorning.VehicleNumber;
            checkListVM.LastUpdated = dailyMorning.LastUpdated;
            checkListVM.Remarks = dailyMorning.Remarks;
            checkListVM.DriverName = dailyMorning.DriverName;
            checkListVM.Region = dailyMorning.Region;
            checkListVM.Subregion = dailyMorning.Subregion;
            checkListVM.Category = "Morning";
            checkListVM.SubCategeory = "General";
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check() 
            { 
                Code = "M1", 
                Description = "Check Engine Oil Level with dip stick", 
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M1").GetValue(dailyMorning, null)) 
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M2",
                Description = "Check Battery watter/Terminal",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M2").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M3",
                Description = "Check Brake",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M3").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M4",
                Description = "Check Coolant water",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M4").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M5",
                Description = "Check Ac Belt",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M5").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M6",
                Description = "Check Genrator Belt",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M6").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M7",
                Description = "Check Accelerator",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M7").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M8",
                Description = "Check Ac/Heater",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M8").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M9",
                Description = "Check All Electric Components",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M9").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M10",
                Description = "Check All Doors",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M10").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M11",
                Description = "Check Tyres Condition",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M11").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M12",
                Description = "Body Check",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M12").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M13",
                Description = "Check Exuast System",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M13").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M14",
                Description = "Check All Cameras",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M14").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M15",
                Description = "Check Radiator Hose Pipe",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M15").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M16",
                Description = "Air Filter Cleaning",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M16").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M17",
                Description = "Check Tyres Air Pressure",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M17").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M18",
                Description = "Check Steering Noise",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M18").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M19",
                Description = "Check Interior Cleaning",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M19").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M20",
                Description = "Check Operate key Log",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M20").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M21",
                Description = "Check ignition Switch",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M21").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M22",
                Description = "Check Trurn On Head Lights",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M22").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M23",
                Description = "Turn On Indicators Lights",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M23").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M24",
                Description = "Check Clutch Pedal",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M24").GetValue(dailyMorning, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "M25",
                Description = "Check Vault Door lock Function",
                Value = Convert.ToBoolean(dailyMorning.GetType().GetProperty("M25").GetValue(dailyMorning, null))
            });

            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }

            return checkListVM;
        }
        public static FMSDailyCheckListVM DailyEveningEngineCheckListToViewModel(FMSDailyEvening dailyEvening)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.Category = "Evening";
            checkListVM.SubCategeory = "Engine";
            checkListVM.VehicleNumber = dailyEvening.VehicleNumber;
            checkListVM.LastUpdated = dailyEvening.LastUpdated;
            checkListVM.Remarks = dailyEvening.Remarks;
            checkListVM.DriverName = dailyEvening.DriverName;
            checkListVM.Region = dailyEvening.Region;
            checkListVM.Subregion = dailyEvening.Subregion;
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE1",
                Description = "Check Engine Oil Level with dip stick",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE1").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE2",
                Description = "Check Battery water Level",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE2").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE3",
                Description = "Check Brake Fluid Level",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE3").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE4",
                Description = "Check Transmission Oil",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE4").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE5",
                Description = "Check Clutch Fluied",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE5").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE6",
                Description = "Check Cloolant Water Level",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE6").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE7",
                Description = "Check Battery terminal",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE7").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE8",
                Description = @"Check P\steering Oil Level",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE8").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE9",
                Description = "Check Smoke Exuast",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE9").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE10",
                Description = "Air Filter cleaning with air pressure",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE10").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EE11",
                Description = "Check electric components",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EE11").GetValue(dailyEvening, null))
            });
            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }
            return checkListVM;
        }
        public static FMSDailyCheckListVM DailyEveningBodyCheckListToViewModel(FMSDailyEvening dailyEvening)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.Category = "Evening";
            checkListVM.SubCategeory = "Body";
            checkListVM.VehicleNumber = dailyEvening.VehicleNumber;
            checkListVM.LastUpdated = dailyEvening.LastUpdated;
            checkListVM.DriverName = dailyEvening.DriverName;
            checkListVM.Region = dailyEvening.Region;
            checkListVM.Subregion = dailyEvening.Subregion;
            checkListVM.Remarks = dailyEvening.Remarks;
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB1",
                Description = "Dents",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB1").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB2",
                Description = "Scratches",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB2").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB3",
                Description = "Check Tyres Condition",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB3").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB4",
                Description = "Check Tyres Air Pressure",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB4").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB5",
                Description = "Check Silencer Condition",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB5").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB6",
                Description = "Front & Rear Bumper",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB6").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EB7",
                Description = "Complete Body Condition",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EB7").GetValue(dailyEvening, null))
            });
            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }
            return checkListVM;
        }
        public static FMSDailyCheckListVM DailyEveningInteriorCheckListToViewModel(FMSDailyEvening dailyEvening)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.Category = "Evening";
            checkListVM.SubCategeory = "Interior";
            checkListVM.VehicleNumber = dailyEvening.VehicleNumber;
            checkListVM.LastUpdated = dailyEvening.LastUpdated;
            checkListVM.DriverName = dailyEvening.DriverName;
            checkListVM.Region = dailyEvening.Region;
            checkListVM.Subregion = dailyEvening.Subregion;
            checkListVM.Remarks = dailyEvening.Remarks;
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI1",
                Description = "Check Brake Pedal",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI1").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI2",
                Description = "Check Accelerator Pedal",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI2").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI3",
                Description = "Check Clutch Pedal",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI3").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI4",
                Description = "Check Operate key Log",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI4").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI5",
                Description = "Check ignition Switch",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI5").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI6",
                Description = "Check Vault Door Function",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI6").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI7",
                Description = "Operate Front & Rear Wipers",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI7").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI8",
                Description = "Check Steering Tilt",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI8").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI9",
                Description = "Check Trurn On Head Lights",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI9").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI10",
                Description = "Turn On Indicators Lights",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI10").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI11",
                Description = "Check Spare Tyres Condition",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI11").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI12",
                Description = "Check Horn",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI12").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI13",
                Description = "Check Gear Shifting",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI13").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI14",
                Description = "Check Gauge Neddle",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI14").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI15",
                Description = "Check Odoo Meter Reading",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI15").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI16",
                Description = "Check Fuel Lid",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI16").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI17",
                Description = "Check Foot mate",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI17").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI18",
                Description = "Check Seat Cover",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI18").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI19",
                Description = "Check Back View Mirror",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI19").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI20",
                Description = "Check Side View Mirror",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI20").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI21",
                Description = "Check Elecrical Cable(Install & Not fit)",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI21").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI22",
                Description = "Check Brake Lights",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI22").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EI23",
                Description = "Trip Wise Daily at the Start & end of Shift",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EI23").GetValue(dailyEvening, null))
            });
            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }
            return checkListVM;
        }
        public static FMSDailyCheckListVM DailyEveningAcCheckListToViewModel(FMSDailyEvening dailyEvening)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.Category = "Evening";
            checkListVM.SubCategeory = "Ac";
            checkListVM.VehicleNumber = dailyEvening.VehicleNumber;
            checkListVM.LastUpdated = dailyEvening.LastUpdated;
            checkListVM.DriverName = dailyEvening.DriverName;
            checkListVM.Region = dailyEvening.Region;
            checkListVM.Subregion = dailyEvening.Subregion;
            checkListVM.Remarks = dailyEvening.Remarks;
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA1",
                Description = "Operate Ac Front & Rear",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA1").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA2",
                Description = "Ac Throw",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA2").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA3",
                Description = "Ac cooling",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA3").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA4",
                Description = "Check Ac Condonser",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA4").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA5",
                Description = "Check Ac Filter",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA5").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EA6",
                Description = "Ac Condensor Cleaning",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EA6").GetValue(dailyEvening, null))
            });
            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }
            return checkListVM;
        }
        public static FMSDailyCheckListVM DailyEveningGeneralCheckListToViewModel(FMSDailyEvening dailyEvening)
        {
            FMSDailyCheckListVM checkListVM = new FMSDailyCheckListVM();
            checkListVM.Category = "Evening";
            checkListVM.SubCategeory = "General";
            checkListVM.VehicleNumber = dailyEvening.VehicleNumber;
            checkListVM.LastUpdated = dailyEvening.LastUpdated;
            checkListVM.DriverName = dailyEvening.DriverName;
            checkListVM.Region = dailyEvening.Region;
            checkListVM.Subregion = dailyEvening.Subregion;
            checkListVM.Remarks = dailyEvening.Remarks;
            checkListVM.Checklist = new List<Check>();
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG1",
                Description = "Fr Grill with Mono Gram",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG1").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG2",
                Description = "Tool Kit Check",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG2").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG3",
                Description = "Check cctv Cameras",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG3").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG4",
                Description = "Daily Vehicle Wash",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG4").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG5",
                Description = "Check Spare Tyre",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG5").GetValue(dailyEvening, null))
            });
            checkListVM.Checklist.Add(new Check()
            {
                Code = "EG6",
                Description = "Check vehicle under the body",
                Value = Convert.ToBoolean(dailyEvening.GetType().GetProperty("EG6").GetValue(dailyEvening, null))
            });
            int totalChecks = checkListVM.Checklist.Count;
            int markedDoneCount = checkListVM.Checklist.Where(x => x.Value == true).Count();

            if (totalChecks == markedDoneCount)
            {
                checkListVM.Status = "Complete";
            }
            else
            {
                checkListVM.Status = "Pending";
            }
            return checkListVM;
        }
    }
}
