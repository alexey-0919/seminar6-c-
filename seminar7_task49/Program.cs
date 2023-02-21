/* Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 */


int InputNumber()
{
    Console.WriteLine("Input number");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int m = InputNumber();
int n = InputNumber();

int[,] arr = new int [m,n];
Random rnd = new Random();

Console.WriteLine(arr.Length);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = rnd.Next(10);
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i%2 == 0 && j%2 == 0)

        arr[i,j] = arr[i,j] * arr[i,j];
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + "  ");
    }
    Console.WriteLine();
}