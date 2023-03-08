// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine("\n\nBuild your matrix: m - for Strings, n - for Rows: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

void ShowArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr [i, j]+" ");
        }
     System.Console.WriteLine();    
    }
}

int [,] GetArray ( int m, int n) 
{   
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(1,10);
        }
    }
    return array;
}

void MinSumString (int [,] array)
{
    List <int> sums = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            
        }
        sums.Add(sum);
    }
  
    int minIndex = 0;
    int min = sums[0];
    for (int k = 0; k < sums.Count; k++)
    {
        if (sums[k]<min)
        {
            min = sums[k];
            minIndex = k;
        }
    
    }
    System.Console.WriteLine ($"The sum {min} in the String - {minIndex} is smallest");
    
}

int [,] a = GetArray(m, n);

ShowArray (a);
MinSumString (a);