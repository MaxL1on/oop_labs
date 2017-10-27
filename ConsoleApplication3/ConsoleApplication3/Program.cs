using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kkk = 12;
            MyData[] mydata = new MyData[5];
            mydata[0] = new MyData(12, 43, 21);
            mydata[1] = new MyData();
            mydata[2] = new MyData(1, 46, 32);
            mydata[3] = new MyData(18, 31, 31);
            mydata[4] = new MyData(9, 43, 43);

            Console.WriteLine("Время с заданным числом часов");
            for (int i = 0; i < mydata.Length; i++)
            {
                if (mydata[i].Hour == kkk)
                {
                    mydata[i].WATCH();
                }
            }

            Console.WriteLine("\n//Список по группам:");
            Console.WriteLine("--Ночь");
            for (int i = 0; i < mydata.Length; i++)
            {
                if (mydata[i].Hour >= 0 && mydata[i].Hour < 6)
                {
                    mydata[i].WATCH();
                }
            }
                Console.WriteLine("\n--Утро");
            for (int i = 0; i < mydata.Length; i++)
            {
                if (mydata[i].Hour >= 6 && mydata[i].Hour < 12)
                {
                    mydata[i].WATCH();
                }
            }
                Console.WriteLine("\n--День");
            for (int i = 0; i < mydata.Length; i++)
            {
                if (mydata[i].Hour >= 12 && mydata[i].Hour < 18)
                {
                    mydata[i].WATCH();
                }
            }
                Console.WriteLine("\n--Вечер");
            for (int i = 0; i < mydata.Length; i++)
            {
                if (mydata[i].Hour >= 18 && mydata[i].Hour < 24)
                {
                    mydata[i].WATCH();
                }
            }
            int hash = mydata[0].GetHashCode();
            Console.WriteLine("\nhash[0] = " + hash);
            Console.WriteLine(mydata[0].ToString());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
