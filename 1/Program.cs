Console.WriteLine("Input length massiva");
int size = Convert.ToInt32(Console.ReadLine());

int [] Arr = new int [size];
Random rnd = new Random();


for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(15);
    
    
}
Console.Write(" [ ");

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + "    ");
}
Console.Write("] ");

int temp = 0;
for (int i = 0; i < Arr.Length/2; i++)
{
    temp = Arr[i];
    Arr[i] = Arr[Arr.Length-i-1];
    Arr[Arr.Length-i-1] = temp;
}

Console.Write(" [ ");

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + "    ");
}
Console.Write("] ");

/* название функции (вводные функции)

void название функции (Вводные данные этой функциии)
{
    for
} */
/* FillRandomArray(Array, size)
void FillRandomArray (int[] Arr, int Arr.Length) */