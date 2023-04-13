//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number % 2 == 0)
{
    Console.WriteLine("Делится без остатка,число четное");
}
else if (number % 2 != 0)
{
    Console.WriteLine("Делится с остатком,число не четное");
}
