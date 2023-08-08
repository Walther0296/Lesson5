// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача №1");

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Задаем элементы массива
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Выводим массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

// Вычисляем количество элементов
int CountEvenNumbers(int[] array)
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

int length = Prompt("Введите количество элементов в массиве > ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($" Количество четных чисел в массиве - {CountEvenNumbers(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача №2");

int Prompt1(string message)
{
    System.Console.Write(message);
    string value1 = Console.ReadLine();
    int result1 = Convert.ToInt32(value1);
    return result1;
}

// Задаем элементы массива
int[] InputArray1(int length1)
{
    int[] array1 = new int[length];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 100);
    }
    return array1;
}

// Выводим массив
void PrintArray1(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($" {array1[i]}");
    }
}

// Вычисление суммы
int Sumevans(int[] array1)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 1)
        {
            sum = sum + array1[i];
        }
    }
    return sum;
}

int length1 = Prompt1("Введите количество элементов в массиве > ");
int[] array1;
array1 = InputArray1(length1);
PrintArray1(array1);
Console.WriteLine();
Console.WriteLine($"Сумма всех нечетных чисел в массиве: {Sumevans(array1)}.");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Задача №3");

double Prompt2(string message)
{
    System.Console.Write(message);
    string value2 = Console.ReadLine();
    double result2 = Convert.ToDouble(value2);
    return result2;
}

// Задаем элементы массива
double[] InputArray2(double length2)
{
    double[] array2 = new double[length];
    Random rand = new Random();
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = rand.NextDouble() * 40 - 20;
    }
    return array2;
}

// Вычисление разницы
double MinMax(double[] array2)
{
    double min = 0.00;
    double max = 0.00;
    Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        
        Console.Write("{0:0.00} ", array2[i]);

        if (array2[i] < min)
        {
            min = array2[i];
        }

        if (array2[i] > max)
        {
            max = array2[i];
        }
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine("Максимальное число в массиве: " + "{0:0.00} ", max);
    Console.WriteLine("Минимальное число в массиве: " + "{0:0.00} ", min);
    double divercity = max - min;
    return divercity;
}


double length2 = Prompt2("Введите количество элементов в массиве > ");
double[] array2;
array2 = InputArray2(length2);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: " +  MinMax(array2)
);