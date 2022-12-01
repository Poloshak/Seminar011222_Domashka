// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int B = 2;
int C = 0;
while (B<=N)
{C = B%2;
    if (C==0){
    Console.WriteLine($"{B} ");
    }
B++;
}
