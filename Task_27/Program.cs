// Задача 27: Напишите функцию, которая принимает на вход число 
// и выдаёт сумму цифр в числе

int SumNumber(int num)
{
    int sum0 = 0;
    while(num >= 1)
    {
        sum0 = sum0 + num % 10;
        num /= 10;
    }
    return(sum0);
}


Console.Write("Ведите целое число: А = ");
int A = Convert.ToInt32(Console.ReadLine());
int sum;
sum = SumNumber(A);
Console.WriteLine(sum);
