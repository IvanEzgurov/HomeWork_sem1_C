// Задача 8: Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введи число");
int a = int.Parse(Console.ReadLine());

int b = 2;
if(a > 1)
{
    while(b <= a)
    {
        Console.Write(b + " ");
        b = b + 2;
    }
}
else
{
    Console.Write("неиспользуемые числа");
}