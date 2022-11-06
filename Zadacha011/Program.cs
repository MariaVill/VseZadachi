//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 99);
Console.WriteLine(number);
int num1 = number / 10;
int num2 = number % 10;
if(num1>num2) Console.WriteLine($"Первая цифра {num1} больше, чем вторая {num2}");
else Console.WriteLine($"Вторая цифра {num2} больше, чем первая {num1}");