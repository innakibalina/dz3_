// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double distanse(int [] dotsA, int [] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsB[0] - dotsA[0], 2) + Math.Pow( dotsB[1] - dotsA[1], 2) + Math.Pow( dotsB[2] - dotsA[2], 2)); //формула вычисления расстояния в трехмерном пространстве d = √((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2)
}

int [] dotsA = new int [3];
int [] dotsB = new int [3];

Console.WriteLine("Enter x (A): ");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter y (A): ");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter z (A): ");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter x (B): ");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter y (B): ");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter z (B): ");
dotsB[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distanse(dotsA,dotsB), 2));