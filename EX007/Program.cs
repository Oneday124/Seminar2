// Программа проверяет пятизначное число на полиндром. Через строки

string n = Convert.ToString(new Random().Next(10000,99999));
if(n[0] == n[4] && n[1] == n[3])
    Console.WriteLine($"Число {n} является полиндромом");
else Console.WriteLine($"Число {n} не является полиндромом");   

