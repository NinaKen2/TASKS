/* Напишите программу, которая принимает на вход три числа
и на выходе показывает максимальное из этих чисел
 2, 3, 7 -> 7 
14, 5, 78 -> 78 */

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Concole.Write("max =");
Concole.WriteLine(max);