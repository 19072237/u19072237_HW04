using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class CoronaVirusPatient : Patient
    {
        private string mSymptomps;

        public string Symptomps { get => mSymptomps; set => mSymptomps = value; }

        public CoronaVirusPatient()
        {

        }

        public CoronaVirusPatient(int id, string name, string sex, int age, bool admitted, string symptomps) : base(id, name, sex, age, admitted)
        {
            Symptomps = symptomps;
        }

        public override string HealthCondition()
        {
            if (Symptomps == "Severe")
            {
                return "Need a Doctor";
            }
            return "No need for Doctor";
        }
    }
}