using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class CovidScreening
    {
        private bool mTravelled;
        private bool mContactWith;
        private bool mHavesymptoms;

        public bool Travelled { get { return mTravelled; } set { mTravelled= value; } }
        public bool Contact { get { return mContactWith; } set { mContactWith = value; } }
        public bool HaveSymptoms { get { return mHavesymptoms; } set { mHavesymptoms = value; } }

        public CovidScreening()
        {

        }

        public CovidScreening(bool travelled, bool contactwith, bool havesymptoms)
        {
            Travelled = travelled;
            Contact =contactwith;
            HaveSymptoms = havesymptoms;
        }


        public string EligibleForCovidTest()
        {
            if(Travelled == true || Contact == true || HaveSymptoms == true)
            {
                return "Eligable";
            }
            return "Not Eligible";
        }
    }
}