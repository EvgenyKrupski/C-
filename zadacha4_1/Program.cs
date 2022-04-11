Console.Write("Введи число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = -numberA;

while (numberB <= numberA)
{
    Console.WriteLine("Число: " + numberB);
    numberB+=1;
}