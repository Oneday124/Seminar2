// Найти расстояние между точками в пространстве 2D
int x1 = new Random().Next(-10,10);
int y1 = new Random().Next(-10,10);
Console.WriteLine($"Координаты точки 1: ({x1};{y1})");
int x2 = new Random().Next(-10,10);
int y2 = new Random().Next(-10,10);
Console.WriteLine($"Координаты точки 1: ({x2};{y2})");

int ab = 0;
int bc = 0;

if(x1 > x2) ab = x1 - x2;
else ab = x2 - x1;

if(y1 > y2) bc = y1 - y2;
else bc = y2 - y1;
double distans = Math.Sqrt((ab*ab)+(bc*bc));

Console.WriteLine(distans);