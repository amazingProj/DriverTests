using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_3300
{

    public class FactoryBL
    {

        static ibl bl = null;
        public static ibl getBL()
        {
            if (bl == null)
                bl = new BL_imp();
            return bl;
        }

    }
}
