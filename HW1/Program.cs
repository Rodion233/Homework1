/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
System.Console.Write("Введите первое число > ");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
System.Console.Write("Введите второе число > ");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
int max = 0;
if (a > b)
{
   System.Console.WriteLine($"Первое число {a} максимальное");
}
else
{
    System.Console.WriteLine($"Второе число {b} максимальное");
}
