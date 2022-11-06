// 1. По двум заданным числам проверять 
// является ли первое квадратом второго
Console.WriteLine("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());
double Squ = Math.Sqrt(number);
Console.WriteLine($"Квадрат числа {number} = {Squ}");
if (Squ % 2 == 0) Console.WriteLine("Да, первое число является квадратом второго");
else Console.WriteLine("Нет, первое число не является квадратом второго");