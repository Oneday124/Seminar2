// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Ввидите число: ");
int number = int.Parse(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"Число {number} кратно 7 и 23");
else if(number % 7 == 0)
    Console.WriteLine($"Число {number} кратно только 7 и не кратно 23");
else if(number % 23 == 0)
    Console.WriteLine($"Число {number} кратно только 23 и не кратно 7");
else
    Console.WriteLine($"Число {number} не кратно ни 7, ни 23");
