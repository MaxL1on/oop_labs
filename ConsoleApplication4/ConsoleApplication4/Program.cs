using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Создать заданный в варианте класс.Определить в классе необходимые
//методы, конструкторы, индесаторы и заданные перегруженные
//операции.Написать программу тестирования, в которой проверяется
//использование перегруженных операций.
//2) Добавьте в свой класс вложенный объект Owner, который содержит Id,
//имя и организацию создателя.Проинициализируйте его
//3) Добавьте в свой класс вложенный класс Date(дата создания).
//Проинициализируйте
//4) Создайте статический класс(например, MathObject), содержащий 3
//метода математического преобразования над объектом вашего класса
//(задания№1) или расчета определенных параметров(например:
//обнуление элементов, поиск максимального, минимального, размер
//объекта и т.п). Позже добавьте к нему метод расширения для типы string
//и вашего типа из задания№1.


///Класс - список Lion. Дополнительно перегрузить следующие
// операции: (+)  добавить элемент в конец(Lion+item); (--) 
// удалить элемент из конца(типа Lion--); (!=) проверка на
// неравенство; true – проверка упорядоченности элементов.
// Методы расширения:
// 1) Подсчет количества слов.
// 2) Проверка на нулевые элементы вписке

namespace OOP4
{
    class Program
    {

        class Lion
        {
            private List<string> stud { get; set; }

            private int a;

            //Добавьте в свой класс вложенный объект Owner, который содержит Id, имя и организацию создателя.Проинициализируйте его

            public class Owner1
            {
                private int ID = 228;
                private string Name = "Me";
                private string Orgname = "VG";
            }

            public Object Owner = new Owner1();

            public void Ownerrr()
            {
                Console.WriteLine(Owner);
            }

            //

            //Добавьте в свой класс вложенный класс Date(дата создания). Проинициализируйте

            public class Date
            {
                int t1;
                int t2;
                int t3;

                public Date(int a, int b, int c)
                {
                    t1 = a;
                    t2 = b;
                    t3 = c;
                }

            }


            //
            public Lion(List<string> n)
            {
                stud = n;
                a = stud.Count;
            } //k1

            public string this[int index]
            {
                set
                {
                    stud[index] = value;
                }

                get
                {
                    return stud[index];
                }
            } //indexator

            public Lion(int n)
            {
                stud = new List<string>(n);
            } //k2


            public static Lion operator +(Lion obj1, string sas)
            {
                obj1.stud.Add(sas);
                return obj1;
            }

            public static Lion operator --(Lion obj1)
            {
                obj1.stud.RemoveAt(obj1.stud.Count - 1);
                return obj1;
            }

            public static bool operator ==(Lion obj1, Lion obj2)
            {
                for (int i = 0; i < obj1.stud.Count; i++)
                {
                    if ((obj1.stud[i] == obj2.stud[i]))
                        return true;
                }
                return false;
            }

            public static bool operator !=(Lion obj1, Lion obj2)
            {
                for (int i = 0; i < obj1.stud.Count; i++)
                {
                    if (obj1.stud[i].Equals(obj2.stud[i]))
                        return false;
                }
                return true;
            }

            public static bool operator false(Lion obj)
            {
                    if (obj.stud == null)
                        return true;
                    else
                        return false;
            }

            public static bool operator true(Lion obj)
            {
                if (obj.stud == null)
                    return false;
                else
                    return true;
            }




            //public static bool operator >(Lion obj1, Lion obj2)
            //{
            //    string g = "0", j = "null";
            //    for (int i = 0; i < obj1.stud.Count; i++)
            //    {
            //        g = g + obj1.stud[i];
            //        j = j + obj2.stud[i];
            //    }
            //    if (g > j) return true;
            //    else
            //        return false;
            //}

            //public static bool operator <(Lion obj1, Lion obj2)
            //{
            //    string g = "0", j = "null";
            //    for (int i = 0; i < obj1.stud.Count; i++)
            //    {
            //        g = g + obj1.stud[i];
            //        j = j + obj2.stud[i];
            //    }
            //    if (g < j) return true;
            //    else
            //        return false;
            //}

            //public static explicit operator int(Lion obj)
            //{
            //    return obj.stud.Count;
            //}

            public void Vivod()
            {
                Console.WriteLine("Массив :");
                for (int i = 0; i < stud.Count; i++)
                {
                    Console.WriteLine(stud[i]);
                }
                Console.WriteLine("");
            } //Вывод

            public override bool Equals(object obj)
            {
                var Lion = obj as Lion;
                return Lion != null &&
                       EqualityComparer<List<string>>.Default.Equals(stud, Lion.stud) &&
                       a == Lion.a;// &&
                                     //  this == Lion.this;
            }

            public override int GetHashCode()
            {
                var hashCode = 754521741;
                hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(stud);
                hashCode = hashCode * -1521134295 + a.GetHashCode();
                hashCode = hashCode * -1521134295 + this.GetHashCode();
                return hashCode;
            }
        }

        static void Main(string[] args)
        {
            Lion stud1 = new Lion(new List<string> { "lol", "kek", "shish-kebab" });
            Lion stud2 = new Lion(new List<string> { "ras", "ras", "eto", "hardbass" });
            Lion stud3 = new Lion(new List<string> { "lol", "kek", "shish-kebab" });
            Lion stud4 = new Lion(new List<string> { "lol", "kek", "shish-kebab" });
            Lion stud5 = new Lion(10);

            if (stud5) { Console.WriteLine("hui"); }
            stud1 = stud1 + "hui";
            stud1.Vivod();
            stud1--;
            stud5.Vivod();
            Console.WriteLine(stud3 != stud4);
            //Lion stud3 = stud2 * stud1;
            //stud3.Vivod();
            //int a = (int)stud3;
            //if (stud2 != stud1)
            //    Console.WriteLine("sas");
            //if (stud2)
            //    Console.WriteLine("ses");
            //else
            //    Console.WriteLine("sos");
            //if (stud2 > stud1)
            //    Console.WriteLine("sasssssss");
            //stud1.Ownerrr();
            Lion.Date time = new Lion.Date(12, 08, 2017);
        }
    }
}



//Вопросы
//1. Каково назначение перегрузки операторов?
//2. Как используется ключевое слово operator?
//3. Какие операции нельзя перегружать в C#?
//4. Можно ли перегрузкой отменить очередность выполнения операции?
//5. Истинно ли следующее утверждение: операция >= может быть
//перегружена.
//6. Сколько аргументов требуется для определения перегруженной
//унарной операции?
//7. Можно ли перегружать операцию []?
//8. Можно ли перегружать операцию ->?
//9. Приведите пример оператора приведения типа
//10.Что такое метод расширения? Как и где его можно использовать?
//11.Пусть дан фрагмент кода определения оператора преобразования типа.
//Определить форму преобразования.
//public static implicit operator Point2D(Point3D a)
//{/* код*/; }
//12.Выберите верное утверждение.Метод расширения может:
//1) получать доступ к public членам расширяемого класса
//2) получать доступ к protected членам расширяемого класса
//3) получать доступ к internal членам расширяемого класса
//4) быть объявлен в любом классе
//5) быть без параметров
//13.Выберите из списка неверное правило перегрузки операторов для C#.
//1) префиксные операции ++ и – – перегружаются парами
//2) операции сравнения перегружаются парами: == и != ; < и >;<= и >=
//3) перегруженные операции обязаны возвращать значения
//4) должны объявляться как protected
//5) true и false можно перегружать
