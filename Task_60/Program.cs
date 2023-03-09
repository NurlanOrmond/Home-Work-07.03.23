// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] array = new int [2,2,2];

int cmp = 1;
for (int k = 0; k < array.GetLength(2); k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int r = new Random().Next(10,100);
            if (r!=cmp)
            {
                array[i,j,k] = r;
                System.Console.Write(array [i,j,k]+"("+i+","+j+","+k+") ");
                cmp = r;
            }
            else
            {
                r = new Random().Next(10,100);
            }
        }
        System.Console.WriteLine();
    }
}