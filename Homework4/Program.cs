Console.WriteLine("И снова здравствуй! Введи целое положительное число больше 1 и ты получишь...");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = 2;

if (number1 > 1) 
{
    while (number2 <= number1)
    {
        Console.Write(number2 + " ");
       
        number2 = number2 + 2;
    }  
    Console.WriteLine("Это все чётные числа до введённого тобой. Пользуйся!");      
}
else
{
    Console.WriteLine("Прочти ещё раз условие и введи корректное число");
}