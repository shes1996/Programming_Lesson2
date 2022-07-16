/*Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.WriteLine("Введите число");
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
*/
/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

string[] days = {"Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 7 && day > 0)
{
    Console.WriteLine(days[day-1]);
}
else Console.WriteLine("Введено некорректное число.");