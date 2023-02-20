System.Console.Write("Размер массива --> ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
/* ReversArray(array, len); */
RecursRevers(array, 0, array.Length-1);
PrintArray(array, len);


void ReversArray(int[] array, int length)
{
int temp;
for (int i = 0; i < length / 2; i++)
{
temp = array[i];
array[i] = array[length - 1 - i];
array[length - 1 - i] = temp;
}
}

void RecursRevers (int[] array, int i, int j)
{
    if (i>=j)
    {
        return;
    }
    else
    {
        int tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
        RecursRevers(array, i+1, j-1);
    }
}




void FillRandomArray(int[] array, int length)
{

for (int i = 0; i < length; i++)
{
array[i] = rnd.Next(100);
}
}

void PrintArray(int[] array, int length)
{
System.Console.Write("[");
for (int i = 0; i < length; i++)
{
if (i < length - 1) System.Console.Write($"{array[i]},");
else System.Console.WriteLine($"{array[i]}]");
}
}