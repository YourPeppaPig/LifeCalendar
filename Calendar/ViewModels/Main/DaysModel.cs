using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels.Main
{
    public class DaysModel
    {
        public List<MonthWithDaysPreview> MonthPrivews { get; set; }

        public List<Goal> Goals { get; set; }

        public string CurrentDate { get; set; }

        public int CurrentYear { get; set; }
    }

    public class MonthWithDaysPreview 
    {  
        public string Month { get; set; }

        public List<DayPreview> DayPreviews { get; set; }
    }

    public class DayPreview
    {
        public string Day { get; set; }

        public DateElementType Type { get; set; }
    }
}
