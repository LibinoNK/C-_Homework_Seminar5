/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int InpuntNumb(string text)
{
    System.Console.WriteLine(text);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int CheckArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int leftRange = 100;
int rightRange = 999;
int size = InpuntNumb("Введите количество чисел в массиве: ");
int[] array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.Write("Массив: ");
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве - {CheckArray(array)}");