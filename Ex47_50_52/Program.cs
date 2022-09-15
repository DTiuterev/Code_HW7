// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задача 47. Задайте двумерный массив размером m x n, я заполню его случайными вещественными числами от 0 до 10.");

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
Console.WriteLine("Ваш массив: ");

void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
}
FillArrayDouble(array);

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + "   ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine();

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine();
Console.WriteLine("Задача 50. Задайте размер двумерного массива, мин и макс элементы, я заполню его случайными числами.");
Console.WriteLine("Затем Вы введете координаты элемента, а я возвращу значение этого элемента или укажу, что такого элемента нет.");

Console.Write("Введите количество строк m: ");
int m50 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n50 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива min: ");
int min50 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива max: ");
int max50 = Convert.ToInt32(Console.ReadLine());
int[,] array50 = new int[m50, n50];
Console.WriteLine("Ваш массив: ");

void FillArray50(int[,] array50)
{
    for (int i = 0; i < m50; i++)
    {
        for (int j = 0; j < n50; j++)
        {
            array50[i, j] = new Random().Next(min50, max50 + 1);
        }
    }
}
FillArray50(array50);

void PrintArray50(int[,] array50)
{
    for (int i = 0; i < m50; i++)
    {
        for (int j = 0; j < n50; j++)
        {
            int alignNumber = array50[i, j];
            Console.Write(alignNumber + "   ");
        }
        Console.WriteLine();
    }
}
PrintArray50(array50);

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m50 && position[1] <= n50 
&& position[0] >= 0 && position[1] >= 0) 
{
  int result = array50[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else
{
    Console.Write("Tакого элемента в массиве нет.");
}

int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for(int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
            break;
            i++;
        }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
    }

    return numbers;
}

string RemovingSpaces (string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ') 
        {
            output += input[i];
        }
    }
    return output;
}
Console.WriteLine();

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine();
Console.WriteLine("Задача 52. Задайте размер двумерного массива целых чисел, мин и макс элементы, я заполню его случайными целыми числами.");
Console.WriteLine("Затем я найду среднее арифметическое каждого столбца.");

Console.Write("Введите количество строк m: ");
int m52 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n52 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива min: ");
int min52 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива max: ");
int max52 = Convert.ToInt32(Console.ReadLine());
int[,] array52 = new int[m52, n52];
Console.WriteLine("Ваш массив: ");

void FillArray52(int[,] array52)
{
    for (int i = 0; i < m52; i++)
    {
        for (int j = 0; j < n52; j++)
        {
            array52[i, j] = new Random().Next(min52, max52 + 1);
        }
    }
}
FillArray52(array52);

void PrintArray52(int[,] array52)
{
    for (int i = 0; i < m52; i++)
    {
        for (int j = 0; j < n52; j++)
        {
            int element = array52[i, j];
            Console.Write(element + "   ");
        }
        Console.WriteLine();
    }
}
PrintArray52(array52);

int[,] arrayNew = new int[m52, n52];
arrayNew = FillArrayNew(array52);

Console.WriteLine();
Console.WriteLine("Cреднее арифметическое: ");
for (int i = 0; i < n52; i++)
{
    double average = 0;
    for (int j = 0; j < m52; j++)
    {
        average += arrayNew[j, i];
    }
    average = Math.Round(average / m52, 2);
    Console.WriteLine($"Столбец № {i+1}: {average}");
}

int[,] FillArrayNew(int[,] array52)
{
    int[,] arrayNew = new int[array52.GetLength(0), array52.GetLength(1)];
    for (int i = 0; i < array52.GetLength(0); i++)
    {
        for (int j = 0; j < array52.GetLength(1); j++)
        {
            arrayNew[i, j] = Convert.ToInt32(array52[i, j]);
        }
    }
    return arrayNew;
}

