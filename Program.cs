// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите значение координаты х первой точки: ");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y первой точки: ");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты z первой точки: ");
int z1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты х второй точки: ");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y второй точки: ");
int y2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты z второй точки: ");
int z2 =Convert.ToInt32(Console.ReadLine());

int sum = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
double distance = Math.Round(Math.Sqrt(sum),2);
System.Console.WriteLine ($"Расстояние между точками = {distance}");