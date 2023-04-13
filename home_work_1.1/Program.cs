// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.WriteLine("Введите второе число: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);

if (number1 > number2)
{ 
    Console.WriteLine( number1 + " первое число больше второго");
}
else if (number1 < number2)
{
    Console.WriteLine(number2 + " второе число больше первого");
}