// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRandomArray()

{
    int[] array = new int[4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(99, 1000);
    }
    return array;
}

int[] array = GetRandomArray();
Console.WriteLine("Начальный массив ");
Console.WriteLine(String.Join(" , ", array));

int countNumber = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        countNumber = countNumber + 1; 
    }
    
}

Console.WriteLine("Количество четных чисел " + countNumber);
// Console.WriteLine(countNumber);

