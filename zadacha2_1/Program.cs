Console.Write("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberA * numberA;

if (square == numberB)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
