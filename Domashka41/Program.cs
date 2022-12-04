// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
int Promt(String message) //Приглашение ко вводу чисел
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Promt("Введите число: ");
int value2 = Promt("Введите число2: ");

double Stepen(int value) //Вычисление степени
{
 double step = Math.Pow(value, value2);
 return step;
}
System.Console.WriteLine( + value + " в степени " + value2 + " равняется " + Stepen(value));