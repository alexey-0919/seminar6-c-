/*  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
 с сторонами такой длины. Теорема о неравенстве треугольника: 
 каждая сторона треугольника меньше суммы двух других сторон. */

int InputNumber()
{
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
 Console.WriteLine("Input nubmer AB");
 int AB = InputNumber();

  Console.WriteLine("Input nubmer BC");
 int BC = InputNumber();

  Console.WriteLine("Input nubmer CA");
 int CA = InputNumber();


if (AB < BC + CA && BC < AB + CA && CA < AB + BC)
    {
        Console.WriteLine("Треугольник существует");
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
