//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число для проверки => ");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);
int remainder = (number % 2);
if (remainder > 0)
{
    Console.WriteLine("Число не чётное");
}
else
{
    Console.WriteLine("Число чётное");
}