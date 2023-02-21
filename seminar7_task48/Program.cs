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
        arr[i,j] = i + j;
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}