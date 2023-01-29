/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() + rand.Next(leftRange, rightRange + 1), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}

int InpuntNumb(string text)
{
    System.Console.WriteLine(text);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

double FindDiffBetweenMaxMin(double[] array)
{
    double result = 0;
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    result = max - min;
    return result;
}


int size = InpuntNumb("Введите необходимый размер массива: ");
double[] array = FillArrayWithRandomNumbers(size, 0, 9);
System.Console.Write("Созданный массив: ");
PrintArray(array);

double res = FindDiffBetweenMaxMin(array);
System.Console.WriteLine($"Разница между минимальным и максимальным элементами массива равна: {Math.Round(res, 2)}");