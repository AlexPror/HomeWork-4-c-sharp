/* Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int dig = number;
int Sum(int number)
{
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int result = Sum(number);
Console.Write($"Сумма цифр в числе {dig} равно: {result}");