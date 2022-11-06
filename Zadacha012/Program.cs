// Удалить вторую цифру трёхзначного числа
// Console.WriteLine("Введите трехзначаное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num < 100 | num >= 1000)
// {
//     Console.WriteLine("Ошибка.Введите трехзначаное число:");
//     num = Convert.ToInt32(Console.ReadLine());
// }

// int NewNum = (num / 100) * 10 + num % 10;
// Console.WriteLine($"При удалении второго числа,получается число {NewNum}");
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int NewNum = (num / 100) * 10 + num % 10;
Console.WriteLine($"При удалении второго числа,получается число {NewNum}");