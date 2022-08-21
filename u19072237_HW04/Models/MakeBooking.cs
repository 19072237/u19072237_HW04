using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class MakeBooking
    {
        private string mName;
        private DateTime mDate;
        private string mReason;
        


        public string Name { get { return mName; } set { mName = value; } }
        public DateTime Date { get { return mDate; } set { mDate = value; } }
        public string Reason { get { return mReason; } set { mReason = value; } }

        public MakeBooking()
        {

        }

        public MakeBooking(string name, DateTime  date, string reason)
        {
            Name = name;
            Date = date;
            Reason = reason;
        }

        

    }
}