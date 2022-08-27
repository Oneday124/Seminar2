// Поиск индекса элемента массива
void FillArray(int[] array, int minimum, int maximum) //наполнение массива рандомными элементами
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(minimum,maximum);
}
int IndexOf(int[] array, int value) //Функция возврата индекса элемента массива, равного заданному значению
{
    for(int i = 0; i < array.Length; i++) // Цикл for - цикл со счетчиком. for(int i(переменная счетка)=0, i<array.Lenght(условие цикла),изменение переменной счетчика после каждой итеррации цикла)
        if(array[i]==value)
            return i;
    return -1; //Если элемент не найден возвращает единицу
}
void PrintArray(int[] array) //Функция печати массива в терминале
{
    foreach(int element in array) // Специальный цикл, создан для прохода по коллекициям и массивам. Переменную этого цикла можно использовать внутри цикла как угодно, но в цикле foreach изменять элементы коллекции нельзя, можно печатать, проверять, считать, но изменять нельзя
        Console.Write($"{element} ");
    Console.WriteLine();
}
void ChengeNegativeElements(int[] array) //Функция присвоения 0 отрицательным элементам массива 
{
    for(int i=0; i<array.Length;i++)
        if(array[i]<0)
            array[i]=0;
}
Console.Write("Enter length of array: "); //Вывод текста на экран - введите длинну массива
int length = int.Parse(Console.ReadLine() ?? "0"); // Перевод введенного значения в int
int[] array = new int[length];
FillArray(array,-10,10); //Вызов функции заполнения масива рандомными значениями в интервале
PrintArray(array); //Вызов функции печати массива
Console.Write("Enter element to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0"); //?? ставится что бы не было желтого текста в терминале перед программиой
int index = IndexOf(array,value); // Присвоение значения индексу элемента, значения, которое возвращает функция возврата элемента массива
if(index == -1) //Если элемент массива не найден
    Console.WriteLine("Array doen'n constains this value "); // вывод этого сообщения
else
    Console.WriteLine($"Index of element: {index}"); //Если индекс найден, то вывод индекса элемента
ChengeNegativeElements(array); //Вызов фцнкции замены значений элементов меньше 0
PrintArray(array);