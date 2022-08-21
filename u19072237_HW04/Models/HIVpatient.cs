using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public class HIVpatient : Patient
    {
        private int mCd4Count;

        public int CD4Count { get => mCd4Count; set =>mCd4Count = value; }
      
        public HIVpatient()
        {

        }

        public HIVpatient(int id, string name, string sex, int age, bool admitted, int cd4Count) : base(id, name, sex, age, admitted)
        {
            CD4Count = cd4Count;
           
        }

        public override string HealthCondition()
        {
            if (CD4Count < 200)
            {
                return "Has AIDS";
            }
            return "Normal CD4count";
        }
    }
}