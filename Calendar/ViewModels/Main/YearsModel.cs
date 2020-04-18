using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels.Main
{
    public class YearsModel
    {
        public List<YearPreview> YearPreviews { get; set; }

        public List<Goal> Goals { get; set; }

        public string CurrentDate { get; set; }
    }

    public class YearPreview
    {
        public string Year { get; set; }

        public DateElementType Type { get; set; }
    }

    public class Goal
    {
        public string Description { get; set; }
    }

    public enum DateElementType
    {
        FILLED, EMPTY, FUTURE
    }
}
