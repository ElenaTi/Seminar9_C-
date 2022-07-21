/*  Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int GetAinPowerB(int a, int b)
{
     if (b == 0) 
     {
        return 1;
     }
    return  GetAinPowerB(a, b - 1) * a;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа N: ");
int B = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($" A = {A}; B = {B} -> {GetAinPowerB(A,B)}");

