/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

 int GetSumFromMToN(int m, int n)
{
    if (m > n) 
    {
        return 0;
    }
    else
    {
       return n + GetSumFromMToN(m, n - 1);
    }
    
} 

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    Console.WriteLine("Ошибка. M должно быть меньше N. Произведена замена M на N: ");
    int temp = M;
    M = N;
    N = temp;
}

Console.WriteLine($"Сумма чисел от {M} до {N} равна: {GetSumFromMToN(M, N)}");
