using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryMVC.Models;
using System.Drawing;

namespace TryMVC.Helper
{
    public class ModelHelper
    {
        public static string GetRangeIndicator(RangeModel range) 
        {
            switch (GetRangeMark(range.Range)) 
            {
                case -1:
                    return "Red";
                case 0:
                    return "Yellow";
                case 1:
                    return "Green";
                default:
                    return "Red";
            }
        }

        private static int GetRangeMark(int range)
        {
            if (range <= 10)
                return -1;
            else if (range < 50)
                return 0;
            else
                return 1;
        }


        internal static string GetRangeCriticality(RangeModel range)
        {
            switch (GetRangeMark(range.Range))
            {
                case -1:
                    return "Critical";
                case 0:
                    return "Mild";
                case 1:
                    return "Normal";
                default:
                    return "Critical";
            }
        }
    }
}