// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int  number = Convert.ToInt32(Console.ReadLine());

int num = 1;

while(num <= number)
{
    if(num %2 ==0)
    Console.WriteLine(num);
    num ++;
}