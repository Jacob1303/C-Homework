Console.WriteLine("Привет, дружище! Введи 3 целых числа и узнаешь кое-что");
Console.Write("Первое число - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число - ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число - ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2) max = number2;
if (max < number3) max = number3;

Console.Write("Наибольшее из 3-х твоих чисел это ");
Console.Write(max);

