using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19072237_HW04.Models
{
    public abstract  class Patient
    {
        private int mID;
        private string mName;
        private string mSex;
        private int mAge;
        private bool misAdmitted;
        
       
        public int ID { get => mID; set => mID = value; }
        public string Name { get => mName; set => mName = value; }
        public string Sex { get => mSex; set => mSex = value; }
        public int Age { get => mAge; set => mAge = value; }
        public bool isAdmitted { get => misAdmitted; set => misAdmitted = value; }
        

        public Patient()
        {

        }


        public Patient(int id, string name, string sex, int age, bool isadmitted)
        {
            ID = id;
            Name = name;
            Sex = sex;
            Age = age;
            isAdmitted = isadmitted;
            
        }


        public virtual string BedAllocated()
        {
            if (isAdmitted)
            {
                return "Allocated";
            }
            return "Not Allocated";

            
        }

        public abstract string HealthCondition();

        



        
       
        

    }
}