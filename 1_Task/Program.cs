/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow */

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

double Pow(int number, int power)
{
    int module_of_power = Math.Abs(power);
    double result = 1; // чтобы работало при power = 0
    for (int i = 0; i < module_of_power; i++)
    {
        result *= number;
    }
    if (power > -1) return result; // (power => 0) не работает , поэтому использует (power > -1)
    else return 1 / result; // a^(-n) = 1 / a^n
}

int A = InputInt("Введите число=");
int B = InputInt("Введите степень числа");

Console.WriteLine($"{A} в степени {B} = {Pow(A,B)}");

// 10 ^(n) - удобно для проверки отрицательных 