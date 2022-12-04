/* Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, 
но больше всех остальных). Сделать одним циклом
[1, 3, 5, 6, 6, 4] -> 5 */
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[] InputArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)

{
    int maxPosition = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}

int maxValueIndx(int[] array)
{
    int maxRange1 = 0;
    int maxRange2 = 0;
    
    for (int i = 0; i <= array.Length; i++)
    {
        maxRange1 = array[0];
       /* if (maxRange1 < array[i])
        {
            max1 = maxRange1;
            maxRange1 = array[i];
        }*/
        if (array[i]< maxRange1)
    {
        maxRange2 = array[i];
        break;
    }

    }
      return maxRange2;
    }
    


int Length = Promt("Введите размер массива  ");
int minRange = Promt("Введите минимальное возможное число в массиве ");
int maxRange = Promt("Введите максимальное возможное число в массиве ");

int[] array = InputArray(Length, minRange, maxRange);

PrintArray(array);
selectionSort(array);

System.Console.WriteLine($" Второй максимум (второе по уменьшению) значение массива это число { maxValueIndx(array)}");