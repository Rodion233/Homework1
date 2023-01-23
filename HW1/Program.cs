/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
System.Console.Write("Введите первое число > ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
System.Console.Write("Введите второе число > ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);
if (num1 > num2)
{
   System.Console.WriteLine($"Первое число {num1} максимальное");
}
else
{
    System.Console.WriteLine($"Второе число {num2} максимальное");
}
