using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class DiabetesPatient : Patient
    {
        private int mGlucoseLevel;
        public int GlucoseLevel { get =>mGlucoseLevel; set => mGlucoseLevel= value; }

        public DiabetesPatient()
        {

        }

        public DiabetesPatient(int id, string name, string sex, int age, bool admitted, int glucoselevel):  base(id, name, sex, age, admitted)
        {
            GlucoseLevel = glucoselevel;
        }

        public override string HealthCondition()
        {
            if (GlucoseLevel > 125)
            {
                return "Has Diabetes";
            }
            else if( GlucoseLevel > 100 & GlucoseLevel < 125)
            {
                return "Prediabetes";
            }
            return "Diabetes Free";
        }
    }
}