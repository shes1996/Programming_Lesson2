/*Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int length = LengthOfNumber(number);
if (length < 3) Console.WriteLine("Нет третьей цифры");
else 
{
    int third = (number / Convert.ToInt32(Math.Pow(10, (length - 3)))) % 10;
    Console.WriteLine("Третья цифра "+ Math.Abs(third));
}


int LengthOfNumber(int number)
{
    int i = 0;
    while (number != 0)
    {
        number /= 10;
        i += 1;
    }
    return i;
}