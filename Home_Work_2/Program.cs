// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumaNaturalNumbers(int count,int count2, int sum)
{
    Console.Write($"{count} ");
    if(count != count2)
    {
        SumaNaturalNumbers(count = count - 1, count2, sum = sum + count);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов {sum} ");
    }
}

int m = 1;
int n = 15;
SumaNaturalNumbers(n , m, n);


Console.WriteLine();
