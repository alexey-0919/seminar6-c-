/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива. */

Random rnd = new Random();
int RandomSizeArray()
{
    int z = rnd.Next(4, 8);
    return z;
}

int x = RandomSizeArray();
int y = RandomSizeArray();

int [,] Array2D = new int [x,y];

FillArray2D(Array2D);
PrintArray2D(Array2D);
ObmenStroArray (Array2D); 
PrintArray2D(Array2D); 

void FillArray2D(int [,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Array2D [i,j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int [,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(1); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write(Array2D[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

int temp = 0;
void ObmenStroArray (int [,] Array2D)
{
    for (int j = 0; j < Array2D.GetLength(1); j++)
    {
        /* for (int i = 0; i < Array2D.GetLength(0); i++)
        { */
            (Array2D[0,j],  Array2D[x-1, j]) = (Array2D[x-1,j],  Array2D[0, j]); // метод замены картедж
            /* temp = Array2D[0,j];
            Array2D[0,j] = Array2D[x-1, j];
            Array2D[x-1, j] = temp; */

        /* } */
    }
    Console.WriteLine();
}