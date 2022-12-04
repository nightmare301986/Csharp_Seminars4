// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
int Prompt(string message) //Приглашение ко вводу числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число > ");

int Raschet(int number) //Вычисление суммы цифр в числе (или просто цифра)
{
    number = Math.Abs(number);

    int sum = 0;

    for (int n3 = number; n3 > 0; n3 /= 10)
    {
        sum += n3 % 10;
    }
    return sum;

}

System.Console.WriteLine($"Сумма цифр в числе равна  {Raschet(number)} ");
