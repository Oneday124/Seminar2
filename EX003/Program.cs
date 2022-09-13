// Дано число. Проверить кратно ли оно 7 и 23. Решение при помощи функции

bool Multiple(int x)
{
    int y = 7;
    bool result = true;
    if (x % y == 0)
        result = true;
    else
        result = false;
return result;
}

Console.WriteLine("Ввидите число: ");
int x = int.Parse(Console.ReadLine() ??"0");

if(Multiple(x))
    Console.WriteLine($"Число {x} кратно 7");
else
    Console.WriteLine($"Число {x} не кратно 7");