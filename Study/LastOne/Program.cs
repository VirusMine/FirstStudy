using System;
using System.Net.Security;
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

/*
Console.Write("Введите свою фамилию: ");
string Familiya = Console.ReadLine();
Console.Write("Введите своё имя: ");
string Name = Console.ReadLine();
Console.Write("Введите своё отчество: ");
string otche = Console.ReadLine();
Console.Write("Введите свой возраст: ");
string Age = Console.ReadLine();
Console.Write("Введите свой пин-код ");
string PinCode = Console.ReadLine();
Console.WriteLine("\nФамилия: " + Familiya + "\nИмя: " + Name + "\nОтчество: " + otche + "\nВозраст: " + Age +"\nВаш пин-код: "+ PinCode+ ".");
*/

/*
int A = 10;
for(A = 0; A < 11; A += 3)
{
    Console.WriteLine("Ваше значение: {0} ", A);
}

*/

/*
int[] mass = new int[5];

mass[0] = 5;
mass[1] = 10;
mass[2] = 20;
mass[3] = 30;
mass[4] = 50;

*/


/*
Console.WriteLine("Переменная массива 1 равна: ",mass[0]);
Console.WriteLine("Переменная массива 2 равна: ", mass[1]);
Console.WriteLine("Переменная массива 3 равна: ", mass[2]);
Console.WriteLine("Переменная массива 4 равна: ", mass[3]);
Console.WriteLine("Переменная массива 5 равна: ", mass[4]);
*/

//  for (mass[0]; mass < 100; mass++)


/*

 int[] mass = new int[5];
 mass[0] = 5;
 mass[1] = 10;
 mass[2] = 20;
 mass[3] = 30;
 mass[4] = 50;

 string[] word = new string[] {"Last", "One", "Together"};

 for (int Lock = 0; Lock < mass.Length; Lock++)
    Console.WriteLine("Значение массива {0}", Lock + ": " + mass[Lock]);
*/

    int[,] mass = new int[5,5]; 
    int summa = 0;
    Random rnd = new Random();

    for (int A = 0; A < mass.GetLength(0); A++)
    {
    for (int B = 0; B < mass.GetLength(1); B++)
        {
        mass[A, B] = (rnd.Next(10, 50));
        Console.Write(mass[A, B] + "\t");

        summa += mass[A, B];
        }
    Console.WriteLine();
}

    Console.WriteLine("\nСумма заданных массивов: " + summa);

    {
        Console.ReadKey();
    }
 