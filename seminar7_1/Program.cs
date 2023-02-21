int[] arr = new int[8];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);   
}

foreach (var item in arr)
{
    Console.Write(item + " ");
}

/* bool f (int x)
{
    return (x > 0);
} */

/* Console.WriteLine("\n" + arr.Count(f)); */
Console.WriteLine("\n" + arr.Count(x=> x>0)); 
// x=> x > 0 Неопределенная функция которая уже заложена в /* bool f (int x)
/* {
    return (x > 0);
} */ 