// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

System.Console.WriteLine("\n\nEnter (m) for strings, (n) for rows: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

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

int [,] SortArray (int [,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int j = 1; j < ar.GetLength(1); j++)
            {
                if (ar [i,j] > ar [i,j-1])
                {
                    int tmp = ar [i,j];
                    ar [i,j] = ar [i, j-1];
                    ar [i,j-1] = tmp;
                    isSorted = false;
                }
                
            }
        } 

    }
    return ar;
}

void ShowArray (int [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write(a [i,j]+" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int [,] a = GetArray (m, n);

ShowArray (a);

int [,] s = SortArray(a);

ShowArray (s);




