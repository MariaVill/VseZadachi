//Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

int[,] createArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

// Заполнение массива

int[,] fillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            var next = new Random().Next(1, 100);
            array[i, j] = min + next * (max - min);
        }
    return array;
}
//Печать массива

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}
void ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temporary = 0;
        temporary = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temporary;
    }
}


 int m = 5;
 int n = 4;
 int[,] array = createArray(m,n);
array = fillArray(array, 5, 10);
printArray(array);
ChangeArray(array);
Console.WriteLine();
printArray(array);