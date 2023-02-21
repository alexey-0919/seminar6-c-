/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

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

int count = 0;
for (int i = 0; i < arr.GetLength(0); i = i + 1)
{
    for (int j = 0; j < arr.GetLength(1); j = j + 1)
    {
        if (i == j)
        count = count + arr[i,j];
    }
    
}
Console.WriteLine();
Console.WriteLine(count);
