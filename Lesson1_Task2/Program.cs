//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число => ");
string firstString = Console.ReadLine();
Console.Write("Введите второе число => ");
string secondString = Console.ReadLine();
Console.Write("Введите третье число => ");
string thirdString = Console.ReadLine();

int first = int.Parse(firstString);
int second = int.Parse(secondString);
int fird = int.Parse(thirdString);
int max = first;

if (second > max)
{
    max = second;
}
if (fird > max)
{
    max = fird;
}
    
Console.Write($"Максимальное число {max}");

