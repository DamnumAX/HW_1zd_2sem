// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

int result = ((num / 10) % 10);

for (int a = 1; a < 3 && (num < 100 | num > 999); a++)
{
Console.Write(a + " Кажется это не трёхзначное число, попробуем ещё раз: ");
num = int.Parse(Console.ReadLine());
}
if (num > 100 | num < 999)
{
Console.WriteLine($"Вторая цифра введённого числа: {result}");
}
while (num < 100 | num > 999)
{
Console.WriteLine("Числа не трехзначные, подумайте над этим и попробуйте снова!(нажмите Ctrl+C) ");
}
