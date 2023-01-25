/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
System.Console.Write("Введите первое число > ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
System.Console.Write("Введите второе число > ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);
System.Console.Write("Введите третье число > ");
string number3 = Console.ReadLine();
int num3 = Convert.ToInt32(number3);
int max = 0;
if (num1 >= num2 && num1 >= num3)
    max = num1;
else if (num2 >= num1 && num2 >= num3)
    max = num2;
else if (num3 >= num1 && num3 >= num2)
    max = num3;
System.Console.WriteLine($"Макимальное число равно {max}");