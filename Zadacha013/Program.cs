// Выяснить, кратно ли число заданному, если нет, вывести остаток.mod%
int num1 = new Random().Next(50, 100);
int num2 = new Random().Next(1, 49);

Console.WriteLine($"Первое число {num1} и второе число {num2}");
if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num1} кратно {num2}");
}
else
{
   Console.WriteLine($"Число {num1} некратно {num2}, остаток от деления равен {num1 % num2}");
}


