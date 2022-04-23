// Задача 29: Напишите программу, которая задаёт массив из 
// некоторого количества элементов и выводит их на экран с 
// помощью функций. (можно спрашивать количество вводимых 
// элементов и вводить все значения с клавиатуры)
// В теле программы вводится размерность массива, в вызываемых 
// методах производится заполнение массива с терминала и вывод
// на печать в терминал

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

void FillingArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Задайте размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] tasks = new int[N];
FillingArray(tasks);
PrintArray(tasks);
