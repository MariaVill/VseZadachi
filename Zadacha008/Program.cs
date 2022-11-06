// Показать четные числа от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i < num)
{
    Console.WriteLine(i);
    i = i + 2;
}

