﻿/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int temp = 0;
for (int i = 0  ; i < N; i++)
{
    
    Console.Write(a + " ");
    temp = a;
    a = b;
    b = a + temp;
}
   
