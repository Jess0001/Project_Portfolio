using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Study_Planner
{
    public class Module
    {
        //Create getters and setters 
        public string Code { get; set; }
        public string Name { get; set; }
        public int NoCredits { get; set; }
        public int WeeklyClassHrs { get; set; }
        public int WeeklyStudyHours { get; set; }
        public int CompleteHours { get; set; }
        public DateTime studDate { get; set; }
        public int AvailableHours { get; set; }

        //Create Sorted set to store data
        public static SortedSet<Module> SetHours = new SortedSet<Module>(new SortHours()) { };

        //Create constructor
        public Module() { }

        //Format information
        public override string ToString()
        {
            return $"{Code}\t\t{WeeklyStudyHours}\t{CompleteHours}({studDate.Date.ToString("dd MMMM yyyy")})\t\t{AvailableHours}";
        }
    }
}
