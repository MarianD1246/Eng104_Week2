using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{ // 2:15
    public class Method
    {

        public static int GetStones(int totalPounds) //1 stone 14 pounds
        {
            return totalPounds > 0? totalPounds/ 14 : 0;
        }
        public static int GetPounds(int totalPounds)
        {
            return totalPounds > 0? totalPounds % 14 : 0;
        }


    }
}
