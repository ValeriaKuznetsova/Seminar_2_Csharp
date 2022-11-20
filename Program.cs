Console.Clear();
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Enter the number from 100 to 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100 || number > 999)
// {
// do
// {
// Console.WriteLine("Wrong number!Enter the number from 100 to 999: ");
// Int32.TryParse(Console.ReadLine(), out number);
// } while (number < 100 || number > 999);
// }
// number = number/10;
// int SecondNumber = number % 10;
// Console.WriteLine("The second number is " + SecondNumber);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter the number:");
int N = Convert.ToInt32(Console.ReadLine());
if (N>100 && N<=999)
{
int thirdNumber1 = N % 10;
Console.WriteLine("The tird number is " + thirdNumber1);
}
if (N<100)
{
Console.Write("Third number doesn't exist");
}
else if (N>999) 
{
while (N>999) 
N = N/10;
{
int thirdNumber2 = N % 10;
Console.WriteLine("The tird number is " + thirdNumber2);
}
}
