using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class TuberculosisPatient : Patient
    {
        private string mGlucoseLevel;
        public string GlucoseLevel { get =>mGlucoseLevel; set => mGlucoseLevel= value; }

        public TuberculosisPatient()
        {

        }

        public TuberculosisPatient(int id, string name, string sex, int age, bool admitted, string glucoselevel):  base(id, name, sex, age, admitted)
        {
            GlucoseLevel = glucoselevel;
        }

        public override string HealthCondition()
        {
            if (GlucoseLevel == "High")
            {
                return "Need a Doctor";
            }
            return "Healthy";
        }
    }
}