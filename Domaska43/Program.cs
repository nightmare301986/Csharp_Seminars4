/* Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции. 
(* Доп сложность, “введите количество элементов массива”, 
“Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)*/

int Promt(String message) //Приглашение ко вводу параметров массива
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray(int Length, int minRange, int maxRange) //Заполнение цикла
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array) //Вывод цикла
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Length0 = Promt("Введите размерность массива  ");
int minRange = Promt("Введите минимальное возможное знаение в массиве ");
int maxRange = Promt("Введите максимальное возможное знаение в массиве ");

int[] arr1 = InputArray(Length0, minRange, maxRange);
PrintArray(arr1);