using System;
using System.Collections.Generic;
using System.Text;

namespace Study_Planner
{
    //Create class to sort order of SetHours set
    class SortHours : IComparer<Module>
    {
        //Compare hours within SetHours
        public int Compare(Module hour1, Module hour2)
        {
            if (hour1.AvailableHours > hour2.AvailableHours)
            {
                return 1;
            }
            else if (hour1.AvailableHours < hour2.AvailableHours)
            {
                return -1;
            }
            else if (hour1.AvailableHours == hour2.AvailableHours)
            {
                return 0;
            }
            return 0;
        }
    }
}
