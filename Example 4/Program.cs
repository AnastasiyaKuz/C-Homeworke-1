// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter numberA : ");
Console.WriteLine("Enter numberB : ");
Console.WriteLine("Enter numberC : ");

string strNumA = Console.ReadLine();
string strNumB = Console.ReadLine();
string strNumC = Console.ReadLine();

int numberA = Convert.ToInt32(strNumA); 
int numberB = Convert.ToInt32(strNumB);
int numberC = Convert.ToInt32(strNumC); 

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
  
Console.Write("max =");
Console.WriteLine(max);
