//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.WriteLine("Введите второе число: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
Console.WriteLine("Введите третье число: ");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);
bool max1 = (number1 > number2) && (number1 > number3);
bool max2 = (number2 > number1) && (number2 > number3);
bool max3 = (number3 > number1) && (number3 > number2);


if (max1)
{
    Console.WriteLine("Первое число больше всех");
}
if (max2)
{
    Console.WriteLine("Второе число больше всех");
}

if (max3)
{
    Console.WriteLine("Третье число больше всех");
}