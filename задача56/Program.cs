// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void NumberRowMinSumElements(int[,] array)
{
int minRow = 0;
int minSumRow = 0;
int sumRow = 0;
for (int c = 0; c < array.GetLength(1); c++)
{
minRow += array[0, c];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
sumRow += array[i, j];

}

if (sumRow < minRow)
{
minRow = sumRow;
minSumRow = i;
}
else
{
sumRow = 0;
}
}
}

Console.Write($" Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:{minSumRow + 1} строка");

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
NumberRowMinSumElements(myArray);