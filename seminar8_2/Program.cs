/*  Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
 если это невозможно, программа должна вывести сообщение для пользователя. */


Random rnd = new Random();
int RandomSizeArray()
{
    int z = rnd.Next(4, 5);
    return z;
}

int x = RandomSizeArray();
int y = RandomSizeArray();

int [,] Array2D = new int [x,y];

FillArray2D(Array2D);
PrintArray2D(Array2D);
if (x == y)
{
ObmenStroArray (Array2D); 
PrintArray2D(Array2D); 
}
else
Console.WriteLine("Замена строк на столбы не возможна, нужен симметричный массив");


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
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            
            Console.Write("{0,5}", Array2D[i,j] + "  "); // Вывод массива с промежутком
            
        }
        Console.WriteLine();
    }
}

/* int temp = 0; */

void ObmenStroArray (int [,] Array2D)
{
   
   /* int b = 0; */
    /* if (x ==y) 
    { */
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        for (int j = i; j < Array2D.GetLength(1); j++)
        {
            (Array2D[i,j],  Array2D[j, i]) = (Array2D[j,i],  Array2D[i,j]);
            /* temp = Array2D[i,j];
            Array2D[i,j] = Array2D[j,i];
            Array2D[j,i] = temp; */
             
        }
      /*  b++; */
    }  

    /* }  */ 
    /* else
    {
        Console.WriteLine("Замена строк на столбы не возможна, нужен симметричный массив");
    } */
    Console.WriteLine();
    
    
   
   
}