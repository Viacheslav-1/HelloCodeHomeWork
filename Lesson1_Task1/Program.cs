//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число => ");
string firstString = Console.ReadLine();
Console.Write("Введите второе число => ");
string secondString = Console.ReadLine();

int first = int.Parse(firstString);
int second = int.Parse(secondString);

if(first == second)
{
Console.Write("Два введённых числа равны");
}
else
{
    if(first > second)
    {
    Console.Write($"Большее число {first}. Меньшее число {second}");
    }
    else
    {
       Console.Write($"Большее число {second}. Меньшее число {first}");  
    }
}