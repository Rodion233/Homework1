/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
System.Console.Write("Введите число > ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
if (num1%2 == 0)
System.Console.WriteLine($"Число {num1} чётное");
else
System.Console.WriteLine($"Число {num1} не чётное");