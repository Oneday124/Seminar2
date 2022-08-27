// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");

if(first == second * second) Console.WriteLine($"Число {first} является квадратом {second}");
else Console.WriteLine($"Число {first} не является квадратом {second}");
