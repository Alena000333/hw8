// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] array3D = new int[2, 2, 2];
void PrintIndex(int[,,] arr)
{

for (int i = 0; i < array3D.GetLength(0); i++)
{
for (int j = 0; j < array3D.GetLength(1); j++)
{
Console.WriteLine();
for (int k = 0; k < array3D.GetLength(2); k++)
{
Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
}
}
}
}

void FillArray(int[,,] arr)
{

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
for (int k = 0; k < arr.GetLength(2); k++)
{
arr[k, i, j] = new Random().Next(-10,10);;

}
}
}
}

FillArray(array3D);
PrintIndex(array3D);
