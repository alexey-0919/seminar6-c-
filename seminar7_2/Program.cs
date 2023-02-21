int[,] arr = new int [3,4];
Random rnd = new Random();

Console.WriteLine(arr.Length);

/* FillArray2(arr, arr.Length); */
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = rnd.Next(100);
    }
}

/* for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
} */

int n = 4;
int count = 0;
foreach (var item in arr)
{
    if (count == n)
    {
        Console.WriteLine();
        count = 0;
    }
    
    Console.Write(item + " ");
    count++;
}


/* void FillArray2 (int [,] arr, int arr.GetLength(0), int arr.GetLength(1) )
{
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = rnd.Next(100);
    }
}
} */