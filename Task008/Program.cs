﻿/* Напишите программу которая на вход принимает число (N), 
а на выходе показывает все четные числаот 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int i=2;

while(i <=N)
{ int i = i + 2;
 Console.WriteLine(i);
}
