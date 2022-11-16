//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CheckNumber(int[] NumberArray)
{
    int quanti = 0;

for (int i = 0; i < NumberArray.Length; i++)
{
    if (NumberArray[i] > 0) quanti++;
}
Console.WriteLine($"Колличество элементов больше 0 : {quanti}");
}


int[] NumberInput(int Quantity) 
{
    int[] NumbersBox = new int[Quantity];

    for (int i = 0; i < NumbersBox.Length; i++)
    {
        NumbersBox[i] = Convert.ToInt32(Console.ReadLine());
    }
    return NumbersBox;
}

Console.Write("Введите кол-во элементов для ввода: ");
int Qua = Convert.ToInt32(Console.ReadLine());

CheckNumber(NumberInput(Qua));


/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void DotCross (double k1, double b1, double k2, double b2)
{
    double x = -(b1 - b2)/(k1-k2);
    double y = k1*x + b1;

    Console.WriteLine($"Точки пересечения двух прямых {x};{y}");
}

Console.WriteLine("Введите точки для двух линий:");

Console.Write("Введите k1: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double m1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double m2 = Convert.ToDouble(Console.ReadLine());

DotCross(n1,m1,n2,m2);
 
 
