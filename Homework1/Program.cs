Console.WriteLine("Введите 2 целых числа");
Console.Write("Число 1 - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2 - ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.Write("Числа равны");
}

if (number1 > number2)
 {
    Console.Write("Большим значением является ");
    Console.WriteLine(number1);
    Console.Write("Меньшим значением является ");
    Console.WriteLine(number2);
}

if (number1 < number2)
{
    Console.Write("Большим значением является ");
    Console.WriteLine(number2);
    Console.Write("Меньшим значением является ");
    Console.WriteLine(number1);
}
    