/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */



Console.WriteLine("Input двухзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9 && n < 100)
{
    string binary = "";

    for (int i = n; i > 0; i = i/2)
    {
        binary = i%2 + binary;
        
    }
    Console.Write(binary);
}
else
{
    Console.WriteLine("Input двухзначное число");
}

