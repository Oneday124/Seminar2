// Определить номер четверти плоскости, в которой находится точка, с координатами Х и У
//При чем Х <> 0 и Y <> 0
int x = new Random().Next(-100,100);
Console.WriteLine($"x = {x}");
int y = new Random().Next(-100,100);
Console.WriteLine($"x = {y}");

if(x > 0 && y > 0)
    Console.WriteLine("Точка находится в 1 четверти");
else if(x < 0 && y > 0)
    Console.WriteLine("Точка находится в 2 четверти");    
else if(y < 0 && x < 0)
    Console.WriteLine("Точка находится в 3 четверти");
else if(y < 0 && x > 0)
    Console.WriteLine("Точка находится в 4 четверти");
else
    Console.WriteLine("x и y не могут быть равны 0");