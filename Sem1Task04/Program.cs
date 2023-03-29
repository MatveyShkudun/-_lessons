// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("ВВедите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("ВВедите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) 
    max = b;
if (c > max) 
    max = c;

else
{
    Console.WriteLine (max);
}