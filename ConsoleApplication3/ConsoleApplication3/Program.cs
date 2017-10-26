using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace esketit7
{
    class Program
    {
        static void Main(string[] args)
        {
            int kkk = 12;
            MyData[] Objmas = new MyData[5];
            Objmas[0] = new MyData(12, 43,21);
            Objmas[1] = new MyData();
            Objmas[2] = new MyData(1, 46,32);
            Objmas[3] = new MyData(18, 31,31);
            Objmas[4] = new MyData(9, 43,43);

            Console.WriteLine("Время с заданным числом часов");
            for (int i = 0; i < Objmas.Length; i++)
            {
                if (Objmas[i].hour == kkk)
                {
                    Objmas[0].WATCH();
                }
            }

            Console.WriteLine("\n//Список по группам:");
            Console.WriteLine("--Ночь");
            for (int i = 0; i < Objmas.Length; i++)
            {
                if (Objmas[i].hour >= 0 && Objmas[i].hour < 6)
                {
                    Objmas[i].WATCH();
                }
            }
                Console.WriteLine("\n--Утро");
            for (int i = 0; i < Objmas.Length; i++)
            {
                if (Objmas[i].hour >= 6 && Objmas[i].hour < 12)
                {
                    Objmas[i].WATCH();
                }
            }
                Console.WriteLine("\n--День");
            for (int i = 0; i < Objmas.Length; i++)
            {
                if (Objmas[i].hour >= 12 && Objmas[i].hour < 18)
                {
                    Objmas[i].WATCH();
                }
            }
                Console.WriteLine("\n--Вечер");
            for (int i = 0; i < Objmas.Length; i++)
            {
                if (Objmas[i].hour >= 18 && Objmas[i].hour < 24)
                {
                    Objmas[i].WATCH();
                }
            }
            int hash = Objmas[0].GetHashCode();
            Console.WriteLine("\nhash[0] = " + hash);
            Console.WriteLine(Objmas[0].ToString());
        }
    }
}
