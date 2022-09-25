// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/* Console.Write("Введите кол-во строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов n: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"m = {rows}, n = {column}");
double[,] numbers = new double[rows, column];

GetArray(numbers);
PrintArray(numbers);

void GetArray(double[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {
        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            a1[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        }
    }
}

void PrintArray(double[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {

        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            Console.Write(a1[i, j] + "; ");
        }
        Console.WriteLine("");
    }
} */

//---------------------------------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/* Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [4,4]; // В примере массив 4х4
GetArray(numbers);
Console.WriteLine();

Console.WriteLine($"m = {rows}, n = {column}");

PrintArray(numbers);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
        {        
            for (int j = 0; j < array.GetLength(1); ++j)
            {
                array [i,j] = new Random().Next(-100, 100) / 10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i,j] + "; ");
        }   
        Console.WriteLine(""); 
    }
}

if (rows > numbers.GetLength(0) && column > numbers.GetLength(1)) {
    Console.WriteLine($"---> В массиве такого элемента нет");
}
else {
    Console.WriteLine($"---> {numbers[rows-1,column-1]}");
} */

//---------------------------------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/* Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, column];
GetArray(numbers);
Console.WriteLine();
PrintArray(numbers);

void GetArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); ++i) {
        for (int j = 0; j < array.GetLength(1); ++j) {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); ++i) {
         for (int j = 0; j < array.GetLength(1); ++j) {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine("");
    }
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < numbers.GetLength(1); ++j) {
    double a1 = 0;
    for (int i = 0; i < numbers.GetLength(0); ++i) {
        a1 = (a1 + numbers[i, j]);
    }
    a1 = Math.Round(a1 / rows, 2);
    Console.Write(a1 + "; ");
} */