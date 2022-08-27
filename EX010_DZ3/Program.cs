// Задать номер четверти, показать диапазоны для возможных координат

string max = "a";
string min = "-a";

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if(num == 1) Console.WriteLine($"Диапазон возможных координат для {num} четверти: X ({0}; {max}), Y ({0}; {max})");
else if(num == 2) Console.WriteLine($"Диапазон возможных координат для {num} четверти: X ({min}; {0}), Y ({0}: {max})");
else if(num == 3) Console.WriteLine($"Диапазон возможных координат для {num} четверти: X ({min}; {0}), Y ({min}; {0})");
else if(num == 4) Console.WriteLine($"Диапазон возможных координат для {num} четверти: X ({0}; {max}), Y ({min}; {0})");
else Console.WriteLine("Введено не корректное значение");
