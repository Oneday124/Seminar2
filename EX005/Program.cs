// Программа проверяет пятизначное число на полиндром

void PrintArray(int[] array) //Функция печати массива в терминале
{
    foreach(int element in array) // Специальный цикл, создан для прохода по коллекициям и массивам. Переменную этого цикла можно использовать внутри цикла как угодно, но в цикле foreach изменять элементы коллекции нельзя, можно печатать, проверять, считать, но изменять нельзя
        Console.Write($"{element} ");
    Console.WriteLine();
}
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int[] array = {0,0,0,0,0};
int i = 0;

while(number > 0)
{
    int current = number % 10;
    array[i] = current;
    i++;
    number = number / 10;
} 
int[] array2 = {0,0,0,0,0};
int index = 0;

while(index < array2.Length)
{
    array2[index] = array[4 - index];
    index++;
}

PrintArray(array);
PrintArray(array2);

int idx = 0;

while(idx < array.Length)
    if(array[idx] == array2[idx])
        idx++;
    else
        break;
if(idx == 5)
    Console.Write("true");
else
    Console.Write("false");


