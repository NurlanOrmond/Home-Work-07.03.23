// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int [,] GetMatrix ()
{
    int [,] arr = new int [2,2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = new Random().Next(0,6);
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
            System.Console.Write(ar [i,j]+" ");
        }
    System.Console.WriteLine();
    }
    
    System.Console.WriteLine("***********************");
}

int [,] MultiplyMatrix (int [,] a, int [,] b)
{
    int [,] c = new int [a.GetLength(0),a.GetLength(1)];
    int k=0;
  
    while ((k+1)<a.GetLength(0))
    {
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                c[i,j] = a[i,k]*b[k,j]+a[i,k+1]*b[k+1,j];
                
            }

        }
        k++;
    }
    return c;
}

System.Console.WriteLine("\n\nTwo matrix multiplication!");

int [,] mat1 = GetMatrix ();
int [,] mat2 = GetMatrix ();
System.Console.WriteLine("First Matrix:");
ShowMatrix(mat1);
System.Console.WriteLine("Second Matrix:");
ShowMatrix(mat2);
System.Console.WriteLine("Result Matrix:");
ShowMatrix(MultiplyMatrix(mat1,mat2));


// for (int i = 0; i < c.GetLength(0); i++)
// {
//     for (int j = 0; j < c.GetLength(1); j++)
//     {
//         System.Console.Write(c[i,j]+" ");
//     }
//     System.Console.WriteLine();
// }

// List <int> str = new List<int>();
// List <int> row = new List<int>();



// for (int i = 0; i < a.GetLength(0); i++)
// {
//     for (int j = 0; j < a.GetLength(1); j++)
//     {
//         str.Add(a[i,j]);
//     }
// }
// foreach (int item in str)
// {
//     System.Console.Write(item+" ");
// }
// System.Console.WriteLine();
// for (int j = 0; j < b.GetLength(1); j++)
// {
//     for (int i = 0; i < b.GetLength(0); i++)
//     {
//         row.Add(b[i,j]);
//     }
// }

// foreach (int item in row)
// {
//     System.Console.Write(item+" ");
// }

// c[0,0] = str[0]*row[0]+str[1]*row[1];
// c[1,0] = str[2]*row[0]+str[3]*row[1];
// c[0,1] = str[0]*row[2]+str[1]*row[3];
// c[1,1] = str[2]*row[2]+str[3]*row[3];

// System.Console.WriteLine();

// for (int i = 0; i < c.GetLength(0); i++)
// {
//     for (int j = 0; j < c.GetLength(1); j++)
//     {
//         System.Console.Write(c[i,j]+" ");
//     }
//     System.Console.WriteLine();
// }