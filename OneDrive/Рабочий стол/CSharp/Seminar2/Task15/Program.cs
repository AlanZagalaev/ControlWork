// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру");
int number = int.Parse(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine("в неделе не более 7 дней, бро");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("weekend");
}
else
{
    Console.WriteLine("not weekend");
}