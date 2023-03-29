//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("ВВедите первое число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("ВВедите второе число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine ($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine ($"Число {b} больше числа {a}");
}