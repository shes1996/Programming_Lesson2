Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int length = LengthOfNumber(number);
if (length < 3) Console.WriteLine("Нет третьей цифры");
else 
{
    int third = (number / Convert.ToInt32(Math.Pow(10, (length - 3)))) % 10;
    Console.WriteLine("Третья цифра "+ third);
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
Console.WriteLine("/n");
string num = Console.ReadLine();
if (num[0] != '-') Console.WriteLine(num[2]);
else Console.WriteLine(num[3]);