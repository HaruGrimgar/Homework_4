/*Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе. 
*/

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int DigitsTotal(int number)
{
    int total = 0;
    while (number > 0)
    {
        total += number % 10;
        number /= 10;
    }
    return total;
}

int number = InputInt("Введите число");
Console.WriteLine($"Сумма цифр числа {number} = {DigitsTotal(number)}");