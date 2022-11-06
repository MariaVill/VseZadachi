// 7. Показать числа от -N до N

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = -num1;
Console.WriteLine($"Список чисел от {num2} до {num1}");
while (num2 <= num1)
{
    Console.WriteLine(num2++);
}
