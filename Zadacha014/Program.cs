// 14. Найти третью цифру числа или сообщить, что её нет
int num = 76245;
int num3 = 0;                        //new Random().Next(1, 10000);
// Console.WriteLine(num);
if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num3 = num % 10;
    Console.WriteLine($"Третья цифра данного числа это {num3}");
}
else Console.WriteLine($"У данного числа тетьей цифры нет");

