// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m1, int n1)
{
    int result = 0;

    if(m1 == 0)
    {
        result = n1 + 1;
    }
    else if(m1 > 0 & n1 == 0)
    {
        result = A(m1 - 1, 1);
    }
    else if(m1 > 0 & n1 > 0)
    {
        result = A(m1 - 1, A(m1, n1-1));
    }

    return result;

}

int m = 3;
int n = 2;

Console.WriteLine(A(m, n));