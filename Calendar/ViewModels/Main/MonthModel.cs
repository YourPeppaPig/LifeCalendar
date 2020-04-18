using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels.Main
{
    public class MonthModel
    {
        public List<YearWithMonthsPreview> YearPreviews { get; set; }

        public List<Goal> Goals { get; set; }

        public string CurrentDate { get; set; }
    }
}

namespace Calendar.ViewModels.Main
{
    public class YearWithMonthsPreview
    {
        public string Year { get; set; }

        public List<MonthPreview> MonthPreview { get; set; }
    }

    public class MonthPreview
    {
        public string Month { get; set; }

        public DateElementType Type { get; set; }
    }
}
