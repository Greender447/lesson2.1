// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter number: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int EvenNumber = 0;
Console.WriteLine("Список всех четных чисел числа " + number);
while ( EvenNumber < number)
{
    EvenNumber = EvenNumber + 1;
     if (EvenNumber % 2 == 0) 
    { 
        Console.WriteLine(EvenNumber); 
        } 
} 
