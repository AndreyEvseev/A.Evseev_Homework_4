// Задача 29: Напишите программу, которая задаёт массив из 
// некоторого количества элементов и выводит их на экран с 
// помощью функций. (можно спрашивать количество вводимых 
// элементов и вводить все значения с клавиатуры)
// В теле программы вводится размерность массива, в вызываемых 
// методах производится заполнение массива рандомными значениями в 
// диапазоне от 0 до 999 и вывод на печать в терминал

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

void FillingArray(int[] numbers)
{
    int min = 1, max = 0;
    while(max < min)
    {
    Console.Write("Задайте минимальное значение элемента массива: ");
    min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте максимальное значение элемента массива: ");
    max = Convert.ToInt32(Console.ReadLine());
    if(max < min) Console.WriteLine("Ошибка! Максимальное значение задано меньше минимального!");
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max + 1);
    }
}

Console.Write("Задайте размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] tasks = new int[N];
FillingArray(tasks);
PrintArray(tasks);