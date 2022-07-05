/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 1 */

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int newDigit = 1;
for (int i = 1; i <= numberB; i++)
{
    newDigit = newDigit * numberA;
}
Console.Write($"Число {numberA} в степени {numberB} равно: {newDigit}");