// Дано число. Проверить кратно ли оно 7 и 23
int num = new Random().Next(23, 1000);
if ( num % 7 == 0) Console.WriteLine($"Число {num} кратно 7");
else Console.WriteLine($"Число {num} не кратно 7");
if ( num % 23 == 0) Console.WriteLine($"Число {num} кратно 23");
else Console.WriteLine($"B число {num} не кратно 23");

