// Программа проверяет пятизначное число на полиндром

void PrintArray(int[] array) //Функция печати массива в терминале
{
    foreach(int element in array) // Специальный цикл, создан для прохода по коллекициям и массивам. Переменную этого цикла можно использовать внутри цикла как угодно, но в цикле foreach изменять элементы коллекции нельзя, можно печатать, проверять, считать, но изменять нельзя
        Console.Write($"{element} ");
    Console.WriteLine();
}
int[] CreateArray (int num)
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    {
        int current = num % 10;
        array[i] = current;
        num = num / 10;
    } 
    return array;
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ??"0");

int[] array = CreateArray(number); 

int[] array2 = new int[5];
int lenght = array.Length;
for(int j = 0; j < lenght; j++)
{
    array2[j] = array[lenght -1 - j];
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


