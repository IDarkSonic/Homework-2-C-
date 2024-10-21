// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число кратно и 7, и 23.");
}
else if(num % 7 ==0)
{
    Console.WriteLine("Число кратно только 7.");
}
else if(num % 23 == 0)
{
    Console.WriteLine("Число кратно только 23.");
}
else
{
    Console.WriteLine("Число не кратно ни 7, ни 23.");
}







