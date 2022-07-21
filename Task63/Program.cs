/* Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N, используя рекурсию.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
GetNumbers(N);

void GetNumbers(int n, int i = 1)
{
    if (i > n) 
    {
        return;
    }
    if ( i == n)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write($"{i}, ");
    }
    GetNumbers(n, i + 1);
}

