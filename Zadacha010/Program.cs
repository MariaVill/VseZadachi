// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 | num >= 1000)
{
    Console.WriteLine("Ошибка. Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int result = (num / 10) % 10;
Console.WriteLine($"Вторая цифра у числа {num} это {result}");