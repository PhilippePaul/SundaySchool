using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundaySchool
{
    public class CheckinEntry
    {
        public Profile Person { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public string Comments { get; set; }

        public CheckinEntry()
        {
            Person = new Profile();
            CheckinTime = DateTime.MinValue;
            CheckoutTime = DateTime.MaxValue;
            Comments = "";
        }
    }
}
