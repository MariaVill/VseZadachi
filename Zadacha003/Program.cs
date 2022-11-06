// 3. По заданному номеру дня недели вывести его название
Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 1 | number > 7)
{
    Console.WriteLine("Неверно. Введите цифру от 1 до 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number == 1) Console.WriteLine($"Сегодня Понедельник");
if (number == 2) Console.WriteLine($"Сегодня Вторник");
if (number == 3) Console.WriteLine($"Сегодня Среда");
if (number == 4) Console.WriteLine($"Сегодня Четверг");
if (number == 5) Console.WriteLine($"Сегодня Пятница");
if (number == 6) Console.WriteLine($"Сегодня Суббота");
if (number == 7) Console.WriteLine($"Сегодня Воскресенье");

// Второй вариант при помощи оператора switch case
// switch (number)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Ошибка"); break;
// }

// Третий вариант 
// class Program
// {
//     static void Main(string[] args)
//     {
//         uint day = uint.Parse(Console.ReadLine());
//         string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
//         Console.WriteLine(day == 7 ? days[0] : day <= 6 && day >= 1 ? days[day] : "ERROR");
//         Console.ReadKey(true);
//     }
// }




