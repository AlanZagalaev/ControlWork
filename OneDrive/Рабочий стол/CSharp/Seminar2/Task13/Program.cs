// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int index = 10;

if (number > 100)
{
    while (number > 1000) {
        number = number / 10;
        index++;
    }
    int result = (number % 10);
    Console.WriteLine("result " + result);
}
else
{
    Console.WriteLine("третьей цифры не будет в этом числе");
}


