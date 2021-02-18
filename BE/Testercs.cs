using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        int Id;
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
        string familyName { get; set; }
        string Name { get; set; }
        gender Gender;
        int phoneNum { get; set; }
        string Adress { get; set; }
        DateTime birth;
        public DateTime birthday
        {
            get
            {
                return birth;
            }
            set { birth = value; }
        }

        int Experience { get; set; }
        int _MaxTests;
        public int MaxTests { get { return _MaxTests; } set { _MaxTests = value; } }
        vehicle Vehile;
        bool[,] _valid = new bool[5, 6];// if 9:00-15:00 per sunday until thuersday.
        int _distance;
        public int distance { get { return _distance; } set { _distance = value; } }

        public bool[,] valid
        {
            get
            {
                return _valid;
            }
            set
            {
                _valid = value;
            }
        }

        //מאפיינים נוספים
        public override string ToString()
        {
            return "ID number :" + id + "familyNumber :" + familyName + " Name :" + Name + " Address is:"
            + Adress;

        }

    }
}
