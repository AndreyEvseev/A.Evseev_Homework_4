// Задача 25: Напишите (функцию) цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B
// Оба числа - целые

int PowerNumberA(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}


Console.Write("Ведите целое число, возводимое в степень: А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите целое число - степень, в которое возводится число А: B = ");
int B = Convert.ToInt32(Console.ReadLine());

int power;
power = PowerNumberA(A, B);
Console.WriteLine(power);
