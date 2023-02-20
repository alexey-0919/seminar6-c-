/* Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
Random rnd = new Random();
FillRandomArray(array, size);
PrintRandomArray(array, size);

void FillRandomArray(int [] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
}

void PrintRandomArray(int [] array, int size)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.Write("]");
}

int [] newarray = new int [size];
for (int i = 0; i < size; i++)
    {
        newarray[i] = array[i];
    }

Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(newarray[i] + "   ");
    }
    Console.Write("]"); 