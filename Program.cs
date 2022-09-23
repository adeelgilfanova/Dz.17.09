using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    struct Student
    {
        public string Secondname;
        public string Firstname;
        public int udentificator;
        public string data_dr;
        public string kategoriya_of_alko;
        public double obiem_of_alko;

        public Student(string Secondname, string Firstname, int udentificator, string data_dr, string kategoriya_of_alko, double obiem_of_alko)
        {
            this.Secondname = Secondname;
            this.Firstname = Firstname;
            this.udentificator = udentificator;
            this.data_dr = data_dr;
            this.kategoriya_of_alko = kategoriya_of_alko;
            this.obiem_of_alko = obiem_of_alko;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия: {Secondname}, Имя: {Firstname}, Идентификатор: {udentificator}, День Рождения: {data_dr}, Категория: {kategoriya_of_alko}, Объем выпитого алкоголя: {obiem_of_alko}");
        }
    }
    struct Utilizer
    {
        public string name_utilizer;
        public string town;
        public int age;
        public int pinkod;

        public Utilizer(string name_utilizer, string town, int age, int pinkod)
        {
            this.name_utilizer = name_utilizer;
            this.town = town;
            this.age = age;
            this.pinkod = pinkod;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя пользователя: {name_utilizer}, Город пользователя: {town}, Возраст: {age}, Пинкод: {pinkod}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Заданий.1");
            Student student1 = new Student("Илья", "Романов", 1, "01.11.2003", "a", 3.1);
            student1.Print();
            Student student2 = new Student("Мария", "Головина", 2, "18.02.2004", "d", 0.01);
            student2.Print();
            Student student3 = new Student("Амир", "Сагдуллин", 3, "26.06.2004", "b", 2.3);
            student3.Print();
            Student student4 = new Student("Маша", "Мошкина", 4, "16.09.2004", "b", 2.2);
            student4.Print();
            Student student5 = new Student("Алина", "Исмагилова", 5, "12.08.2004", "c", 1.3);
            student5.Print();
            double obiem_alko = student1.obiem_of_alko + student2.obiem_of_alko + student3.obiem_of_alko + student4.obiem_of_alko + student5.obiem_of_alko;
            Console.WriteLine($"Первый студент выпил: {Math.Round((student1.obiem_of_alko/obiem_alko)*100,1)}%");
            Console.WriteLine($"Второй студент выпил: {Math.Round((student2.obiem_of_alko / obiem_alko) * 100, 1)}%");
            Console.WriteLine($"Третий студент выпил: {Math.Round((student3.obiem_of_alko / obiem_alko) * 100, 1)}%");
            Console.WriteLine($"Четвертый студент выпил: {Math.Round((student4.obiem_of_alko / obiem_alko) * 100, 1)}%");
            Console.WriteLine($"Пятый студент выпил: {Math.Round((student5.obiem_of_alko / obiem_alko) * 100, 1)}%");
            Console.WriteLine($"Общий объем выпитого алкоголя:{obiem_alko} \n");


            Console.WriteLine("Задание.2");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"bool - true - false");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"string - Ограничено системной памятью");
            Console.WriteLine($"object - Можно закинуть почти все");
            Console.WriteLine($"char - {char.MaxValue} - {char.MinValue} \n");


            Console.WriteLine("Задача.3");
            Utilizer utilizer = new Utilizer();
            Console.WriteLine("Введите имя: ");
            utilizer.name_utilizer = Console.ReadLine();
            Console.WriteLine("Введите город: ");
            utilizer.town = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            utilizer.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Пинкод: ");
            utilizer.pinkod = int.Parse(Console.ReadLine());
            utilizer.Print1();
            Console.WriteLine("\n");

            Console.WriteLine("Задача.4");
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            string initials = $"{name[0]}.{surname[0]}";
            Console.WriteLine($"Ваши инициалы:  {initials} \n"); 

            Console.WriteLine("Задача.5");
            Console.WriteLine("Введите стандартную стоимость бутылки Виски(normPrice):");
            int normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку на стоимость бутылки Виски(salePrice):");
            int salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска(holidayPrice):");
            int holidayPrice = int.Parse(Console.ReadLine());
            double amount_of_bottle = holidayPrice / ((normPrice * salePrice) / 100);
            if (Math.Round(amount_of_bottle)>amount_of_bottle)
            {
                Console.WriteLine(amount_of_bottle-1);
            }
            else
            {
                Console.WriteLine(amount_of_bottle);
            }

            Console.WriteLine("\n Задача.6");
            Console.WriteLine("Введите скорость таракашки в км/ч: ");
            double speed_of_km = double.Parse(Console.ReadLine());
            double speed_of_metr = (speed_of_km*27.7778);
            if (Math.Round(speed_of_metr) > speed_of_metr)
            {
                Console.WriteLine(Math.Round(speed_of_metr) - 1);
            }
            else
            {
                Console.WriteLine(Math.Round(speed_of_metr));
            }

            Console.WriteLine(" \n Задача.7");
            Console.WriteLine("Введите строчку: ");
            string string1 = Console.ReadLine();
            char[] massOfline = new char[200];
            int n = 0;
            int indexOfletter = 0;
            while (n != string1.Length)
            {
                indexOfletter = (int)string1[n];
                if (indexOfletter >= 65 && indexOfletter <= 90)
                {
                    massOfline[n] = (char)(indexOfletter + 32);
                }
                if (indexOfletter >= 97 && indexOfletter <= 122)
                {
                    massOfline[n] = (char)(indexOfletter - 32);
                }
                n++;
            }
            Console.WriteLine(massOfline);
            Console.ReadKey();
        }
    }
}
