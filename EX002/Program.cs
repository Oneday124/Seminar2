// Дано число. Проверить кратно ли оно 7 и 23
bool Fun (int number)
{
    if(number % 7 == 0 && number % 23 == 0)
    {
        return true;
    }
    else
        return false;
}
Console.WriteLine("Ввидите число: ");
int number = int.Parse(Console.ReadLine() ??"0");

Console.WriteLine(Fun(number));
