// Найти расстояние между точками в пространстве 3D

int x1 = new Random().Next(-10,10);
int y1 = new Random().Next(-10,10);
int z1 = new Random().Next(-10,10);
Console.WriteLine($"Координаты точки 1: ({x1};{y1};{z1})");
int x2 = new Random().Next(-10,10);
int y2 = new Random().Next(-10,10);
int z2 = new Random().Next(-10,10);

Console.WriteLine($"Координаты точки 2: ({x2};{y2};{z2})");

int ab = 0;
int bc = 0;
int ce = 0;

if(x1 > x2) ab = x1 - x2;
else ab = x2 - x1;

if(y1 > y2) bc = y1 - y2;
else bc = y2 - y1;

if(z1 > z2) ce = x1 - z2;
else ce = z2 - z1;

double distans = Math.Sqrt((ab*ab)+(bc*bc)+(ce*ce));

Console.WriteLine(distans);