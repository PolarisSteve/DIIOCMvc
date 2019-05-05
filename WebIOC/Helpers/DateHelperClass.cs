using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebIOC.Helpers
{
    public interface IDisplayDateClass
    {
        string ShowDateString { get; }
    }

    
    public class dateHelper : IDisplayDateClass
    {

        ILogger _lg;

        public dateHelper(ILogger<dateHelper> lg)
        {
            _lg = lg;
        }

        DateTime dt;

        public dateHelper()
        {
            dt = DateTime.Now;
        }
        private int getDaysInMonth()
        {
            _lg.LogInformation("Date selected " + dt.ToString());    
            return DateTime.DaysInMonth(dt.Year, dt.Month);
        }
        public string ShowDateString { get { return string.Format("The number of days in the month is: {0}", getDaysInMonth().ToString()); } }


    }

}
