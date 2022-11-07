// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
redo:
switch (number)
{
    case 1: Console.WriteLine("Сегодня понедельник"); break;
    case 2: Console.WriteLine("Сегодня вторник"); break;
    case 3: Console.WriteLine("Сегодня среда"); break;
    case 4: Console.WriteLine("Сегодня четверг"); break;
    case 5: Console.WriteLine("Сегодня пятница"); break;
    case 6: Console.WriteLine("Сегодня суббота. Это выходной"); break;
    case 7: Console.WriteLine("Сегодня воскресенье.Это выходной"); break;
    default:
        while (number < 1 || number > 7)
        {
            Console.WriteLine("Вы ошиблись, введите число от 1 до 7:");
            number = Convert.ToInt32(Console.ReadLine());
        }
        goto redo;
}
