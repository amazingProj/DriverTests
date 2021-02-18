using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        int ID;
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        string firstName;
        string lastName;
        gender Gender;
        string phoneNum;
        string Adress;
        DateTime birth;
        public DateTime birthday
        {
            get
            {
                return birth;
            }
            set { birth = value; }
        }
        string vechile;
        //תיבת הילוכים 
        string school;
        string teacher;
        string numOfLessons;
        public override string ToString()
        {
            return "firstName :" + firstName + " lastName :" + lastName;
        }
    }
}

    
