using System;
using System.Net.Security;

namespace LastOne
{
    class Program
    {
        static void Main()
        {
            /*    char Toch = '.';
                int num_1 = 0;
                int num_2 = 0;
                Console.Write("Введите первое значение:");
                num_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе значение:");
                num_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Первое значение: " + num_1 + Toch + "  Второе значение: " + num_2 + Toch);
            */

            /* 
           float user = 0;
           float result = 0;
           Console.WriteLine("Введите число с точкой: ");

            user = float.Parse(Console.ReadLine());
            result = user + 10f;
            result *= 10;
            result++;
            result--;
            result /= 5;

            Console.WriteLine("Переменная: " + result);
            Console.ReadKey();
           */


            //  Console.WriteLine(Math.PI);           // = 3.14...
            //  Console.WriteLine(Math.Abs(-100));    // = 100
            //  Console.WriteLine(Math.Floor(11.95)); // = 11
            //  Console.WriteLine(Math.Round(5.55));  // = 6
            //  Console.WriteLine(Math.Min(10, 5));   // = 5
            //  Console.WriteLine(Math.Max(10, 5));   // = 10
            //  Console.WriteLine(Math.Pow(5 , 2));   // = 25



            /*Console.WriteLine("Введите радиус круга в см: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow (radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0} см равна {1} см : ", radius, area);
           
            bool HasCar = false;
            double number = 150;
          
              if (number < 150 || HasCar)
                  Console.WriteLine("Число менее 150.");
              else if (number == 150)
                  Console.WriteLine("Число равно 150, как в аптеке!.");
              else
                  Console.WriteLine("Неопознанное число.\nПопробуйте ещё раз.");
            */

            /*
            if (number < 150 || HasCar)
                Console.WriteLine("Что-то из этого верно, либо верно всё.");
         
           else Console.WriteLine("Ничего не верно.");

            */

            /*
            if (HasCar)
                Console.WriteLine("He has car!");
            else
                Console.WriteLine("He has not car!");
            */

            Console.Write("Введите свою фамилию: ");
            string Familiya = Console.ReadLine();
            Console.Write("Введите своё имя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите своё отчество: ");
            string otche = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            string Age = Console.ReadLine();
            Console.WriteLine("\nФамилия:" + Familiya + "\nИмя:" + Name + "\nОтчество:" + otche + "\nВозраст: " + Age + ".");
             
            {
                Console.ReadKey();
            }





        }
    }
}