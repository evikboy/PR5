using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    class man
    {
        string surname;
        int age;
        string colorHair;
        string address;

        public void input(int i)
        {
            Console.WriteLine("\nМужчина номер {0}", i);
            Console.Write("Введите фамилию мужчины: ");
            surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Введите цвет волос: ");
            colorHair = Console.ReadLine();

            Console.Write("Введите адрес проживания: ");
            address = Console.ReadLine();
        }

        public void output(ref string desireColor, ref int desireAge, int i)
        {
            if (colorHair == desireColor && age < desireAge)
            {
                Console.WriteLine("\nМужчина номер {0} подходит", i);
                Console.WriteLine("Его фамилимя - {0}, возраст - {1}, цвет волос - {2}, адрес проживания - {3}", surname, age, colorHair, address);
            }
            else Console.WriteLine("\nМужчина номер {0} не подходит", i);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int countMan;
            Console.Write("Введите количество мужчин: ");
            countMan = int.Parse(Console.ReadLine());

            man[] a = new man[countMan];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new man();
                a[i].input(i);
            }

            string desireColor;
            int desireAge;

            Console.Write("\nВведите желаемый цвет волос мужчины для поиска: ");
            desireColor = Console.ReadLine();
            Console.Write("Младше скольки лет: ");
            desireAge = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                a[i].output(ref desireColor, ref desireAge, i);
            }
            Console.WriteLine("Finish!");

            Console.ReadKey(true);
        }
    }
}
