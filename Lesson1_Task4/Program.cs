//  Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 2 до N.
Console.Write("Введите число для проверки => ");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);
int numberStart = 2;
while(numberStart<number)
{
    Console.Write($"{numberStart}, ");
    numberStart = numberStart +2;
}
Console.Write(numberStart);
