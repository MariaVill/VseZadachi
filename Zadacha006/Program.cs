// 6. Выяснить является ли число чётным
// если есть логическое выражение,то используют if. если есть шаблон, то switch
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) Console.WriteLine("Да. Число является четным");
else Console.WriteLine("Нет. Число не является четным");
