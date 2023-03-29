// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter numberA : ");
Console.WriteLine("Enter numberB : ");

string strNumA = Console.ReadLine();
string strNumB = Console.ReadLine();

int numberA = Convert.ToInt32(strNumA); 
int numberB = Convert.ToInt32(strNumB); 

int max = numberA;
int min = numberA;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}
else
{
    max = numberB;
    min = numberA;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}