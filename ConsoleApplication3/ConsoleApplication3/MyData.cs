using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    partial class MyData
    {
        private int _second;
        private int _minute;
        private int _hour;
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value <= 59 && value >= 0)
                    _second = value;
            }
        }
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value <= 59 && value >= 0)
                    _minute = value;
            }
        }
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value <= 23 && value >= 0)
                    _hour = value;
            }
        }
        public readonly static int ID ;

        private const int Esketit = 1;


        public MyData(int a, int b, int c)
        {
            Hour = a;
            Minute = b;
            Second = c;
        }

        static MyData()
        {
            ID = 5;
        }

        public MyData(int a, int c = 10)
        {
            Hour = a;
            Second = c;
        }

        public MyData()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public void WATCH()
        {
            Console.WriteLine("Время: ");
            Console.WriteLine(Hour + " часов " + Minute + " минут " + Second + " секунд ");
        }
    }
}
