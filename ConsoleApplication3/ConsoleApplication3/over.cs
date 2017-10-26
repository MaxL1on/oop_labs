using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esketit7
{
   partial class MyData
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            MyData m = obj as MyData;
            if (m as MyData == null)
                return false;
            return m.second == this.second;
        }

        public override int GetHashCode()
        {
            int unitCode;
            if (hours == 0)
                unitCode = 1;
            else unitCode = 2;
            return (int)hours + unitCode;
        }

        public override string ToString()
        {
            return hours+" chasov "+minutes+" minut "+second+" sekund" ;
        }
    }
}
