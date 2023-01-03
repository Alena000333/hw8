// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] Create2DRandomArray ( int rows, int columns)
{
int[,] newArray = new int[rows,columns];
for(int i = 0; i < rows; i++)
{
for(int j = 0; j < columns; j++)
{
newArray[i,j] = new Random().Next(1,11);
}
}
return newArray;
}

void SortRows(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
for (int c = 0; c < array.GetLength(1) - 1; c++)
{
if (array[i, c] < array[i, c + 1])
{
int temp = array[i, c + 1];
array[i, c + 1] = array[i, c];
array[i, c] = temp;
}
}
}
}
}

void Show2DArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j]+" ");
}
Console.WriteLine();
}
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] myArray = Create2DRandomArray(m,n);

Show2DArray(myArray);
Console.WriteLine();
SortRows(myArray);
Console.WriteLine();
Show2DArray(myArray);