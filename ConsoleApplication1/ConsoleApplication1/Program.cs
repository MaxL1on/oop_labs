using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {

            ///Кортежи
            static Tuple<int, string, char, string, ulong> Corteg(int a, string st1, char chch, string st2, ulong uu)
            {
            int b = a;
            string s1 = st1;
            char ch1 = chch;
            string s2 = st2;
            ulong u = uu;
                return Tuple.Create<int, string, char, string, ulong>(b, s1, ch1,s2,u);
            }
        static void Main(string[] args)
        {
            sbyte asbyte = 4;
            short ashort = 4;
            int aint = 4;
            long along = 4;
            byte abyte = 4;
            ushort aushort = 4;
            uint auint = 4;
            ulong aulong = 4;
            char achar = 'm';
            bool abool = true;
            float afloat = 4;
            double adouble = 4.44;
            decimal adecimal = 4;

            // Приведение
            Int16 int16 = 16;
            Int32 int32 = int16;
            Int64 int64 = int32;
            long lng = int64;
            double dbl = lng;

            float flt = (float)dbl;
            byte bt = (byte)flt;
            uint ui = (uint)bt;
            ulong ulng = (ulong)ui;
            ushort ushrt = (ushort)ulng;

            // Упаковка/распаковка
            Int16 i16 = 8;
            Object o = i16;
            byte b = (byte)(Int16)o;

            // Var
            var x = 'z';
            var y = 32;
            var z = true;
            var mass = new List<int>(new int[] { 14, 15, 77, 55, 73, 245 });
            Console.WriteLine(mass.GetType()); Console.WriteLine();

            // Nullable
            int? x1 = null;
            int? x2 = null;
            Console.Write(x1 == x2);

            int? y1 = 2;
            // Null-объединение
            int? t = x1 ?? y1;
            int? g = y1 ?? x1;
            Console.WriteLine(t);
            Console.WriteLine(g);

            /// Задание №2
            String strng1 = "Chechnya";
            String strng2 = "Kruto";
            char[] delim = { ' ' };
            Console.WriteLine(String.Compare(strng1, strng2));
            // Операции над строками
            String strng = "Это";
            String tstrng = String.Join(" ", strng1, strng, strng2);
            Console.WriteLine(tstrng);
            strng2 = String.Copy(strng1);
            Console.WriteLine(strng2);
            String sstrng = tstrng.Substring(9, 3);
            Console.WriteLine(sstrng);
            String[] substrng = tstrng.Split(delim);
            Console.WriteLine(substrng[2]);
            String istrng = tstrng.Insert(13, "ОЧЕНЬ ");
            Console.WriteLine(istrng);
            String rstrng = istrng.Replace(substrng[0], null);
            Console.WriteLine(rstrng);
            String estrng = "";
            String nstrng = null;
            Console.WriteLine("Is estrng empty? " + String.IsNullOrEmpty(estrng));
            Console.WriteLine("Is nstrng empty? " + String.IsNullOrEmpty(nstrng));
            //StringBuilder
            StringBuilder abc = new StringBuilder("ABC", 50);
            abc.Append(new char[] { 'D', 'E', 'F' });
            abc.AppendFormat("GHI{0}{1}", "j", "K");
            Console.WriteLine("{0} chars: {1}", abc.Length, abc.ToString());
            abc.Insert(0, "Alphabet: ");
            abc.Replace('j', 'J');
            Console.WriteLine("{0} chars: {1} ", abc.Length, abc.ToString());
            abc.Remove(0, 10);
            Console.WriteLine("{0} chars: {1} ", abc.Length, abc.ToString());
            abc.Insert(11, " is alphabet");
            Console.WriteLine("{0} chars: {1} ", abc.Length, abc.ToString());

            ///Массивы
            int pos;
            string change;
            //Матрица
            Console.WriteLine("Массив:");
            int[,] arr = new int[4, 6];
            Random rn = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = rn.Next(1, 10);
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine("{0}\n", "");
            }
            //Стринговый
            string[] arr1 = { "Казнить", " ", "нельзя", " ", "помиловать" };
            for (int n = 0; n < arr1.Length; n++)
            {
                Console.WriteLine("Номер элемента: " + n + ";\t" + arr1[n]);
            }
            Console.WriteLine("Длина массива строк: " + arr1.Length);
            Console.WriteLine("Введите номер элемента:");
            pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь введите строку:");
            change = Console.ReadLine();
            arr1[pos] = change;
            for (int i = 0; i < arr1.Length; i++) { Console.Write(arr1[i]); }
            Console.WriteLine();
            //Ступенчатый
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            Console.WriteLine("Введите значения массива:");
            for (int i = 0; i < 2; i++)
            {
                myArr[0][i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                myArr[1][i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                myArr[2][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0}\t", myArr[0][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}\t", myArr[1][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t", myArr[2][i]);
            }
            Console.WriteLine();

            var v = new[] { 0, 1, 2, 3 };
            var v1 = "kek";

            ///Кортежи
            Console.WriteLine("\n\t\t\tРабота с кортежами");
            var myTuple = Corteg(25, "Alexandr",'s',"hi",245);
            Console.WriteLine("Кортеж полностью:");
            Console.WriteLine("{0}\t", myTuple);
            Console.WriteLine("Кортеж частично:");
            Console.WriteLine("{0}\t{1}\t{2}\t", myTuple.Item1, myTuple.Item3, myTuple.Item4);
            //Распаковка кортежа
            int it = (int)myTuple.Item1;
            Console.WriteLine(it);

            //Kортеж произвольной размерности
            var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short, Tuple<int, string, char, string, ulong>>(12, 'C', "Name", 12.3892m, 0.5f, 120, 4501, myTuple);

            Console.WriteLine(myTuple.Equals(myTuple2));

        }
    }
}