// Программа проверяет пятизначное число на полиндром. Решение группы

int x = int.Parse(Console.ReadLine() ??"0");

int a1 = (x / 10000);
int a2 = (x / 1000)-a1*10;
int a5 = (x % 10);
int a4 = ((x % 100)-a5)/10;

if(a1 == a5 && a2 == a4)
    Console.WriteLine($"Число {x} является полиндромом");
else Console.WriteLine($"Число {x} не является полиндромом");