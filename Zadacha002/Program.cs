// 2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB) Console.WriteLine($"Число {numberA} больше, чем {numberB}");
else Console.WriteLine($"Число {numberA} меньше, чем {numberB}");
