using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
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
            return m.Second == this.Second;
        }

        public override int GetHashCode()
        {
            int unitCode;
            if (Hour == 0)
                unitCode = 1;
            else unitCode = 2;
            return (int)Hour + unitCode;
        }

        public override string ToString()
        {
            return Hour + " часов " + Minute + " минут " + Second + " секунд";
        }
    }
}
