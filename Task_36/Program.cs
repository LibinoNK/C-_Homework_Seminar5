/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

//ПЕРВЫЙ ВАРИАНТ ФУНКЦИИ - проверяем все индексы на четность
int SumOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
        sum += array[i];
        }
    }
    return sum;
}

//ВТОРОЙ ВАРИАНТ ФУНКЦИИ - сразу задаем первый нечетный индекс 1 и идем только по нечетным индексам
int SumOfOdd2(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = InpuntNumb("Введите количество чисел в массиве: ");
int[] array = FillArrayWithRandomNumbers(size, -100, 99);
System.Console.Write("Созданный массив: ");
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных чисел в массиве равна {SumOfOdd(array)}");
System.Console.WriteLine($"Сумма нечетных чисел в массиве равна {SumOfOdd2(array)}");
