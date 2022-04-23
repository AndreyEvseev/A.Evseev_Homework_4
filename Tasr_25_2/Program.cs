// Задача 25: Напишите (функцию) цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B
// B - целое, A - рациональное с округлением до одного знака 
// после запятой

double PowerNumberA(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}


Console.Write("Ведите число, возводимое в степень, с одним знаком после запятой: А = ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите целое число - степень, в которое возводится число А: B = ");
int B = Convert.ToInt32(Console.ReadLine());

double power;
power = PowerNumberA(A, B);
Console.WriteLine(power);
