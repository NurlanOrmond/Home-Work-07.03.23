// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

int [,] GetMatrix ()
{
    int [,] arr = new int [4,4];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = new Random().Next(0,20);
        }
    }
    return arr;
}



void ShowMatrix (int [,] ar)
{
    System.Console.WriteLine("***********************");
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            System.Console.Write($"{ar [i,j]:D2}"+" ");
        }
    System.Console.WriteLine();
    }
    
    System.Console.WriteLine("***********************");
}

int [,] SpiralSort (int [,] s)
{
    List <int> list = new List<int>();               // Transform matrix to List to Sort elements

        for (int i = 0; i < s.GetLength(0); i++)
        {
            for (int j = 0; j < s.GetLength(1); j++)
            {
                list.Add (s[i,j]);
            }
        
        }

    int tmp;                                   //Sorting min => max
    bool isSorted = false;
    while (!isSorted)
    {
        isSorted = true;
        for (int i = 1; i < list.Count; i++)
        {
            if (list [i] < list [i - 1])
            {
                tmp = list [i];
                list [i] = list [i-1];
                list [i-1] = tmp;
                isSorted = false;
                
            }
        }
    }
    int [] sample = {0,1,2,3,11,12,13,4,10,15,14,5,9,8,7,6}; // Sample order. For 4x4 matrix only!!!


    int [] prm = new int [16];                            // Merging Sample Order Indexes with Sorted List 

    int n = 0;
    int k = 0;
    for (int i = 0; i < prm.Length; i++)
    {
        k = sample [n];
        prm [i] = list[k];
        n++;
    }

    int [,] fin = new int [4,4];                                    // Coverting to 2d Array
    int m = 0;
    for (int i = 0; i < fin.GetLength(0); i++)
    {
        for (int l = 0; l < fin.GetLength(1); l++)
        {
            fin [i,l] = prm [m];
            m++;
        
        }
    
    }
    return fin;
}

int[,] a = GetMatrix();

ShowMatrix(a);

ShowMatrix (SpiralSort(a));