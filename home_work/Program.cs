Console.Write("Введите A: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите B: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);

if (number2 * number2 == number1)
{
Console.WriteLine("A является квадратом B");
}
else
{
Console.WriteLine("A не является квадратом B");
}