// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

int [] GetRandomArray()
{
    int[] array = new int[4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100, 100);
    }
    return array;
}

int[] array = GetRandomArray();
Console.WriteLine("Начальный массив ");
Console.WriteLine(String.Join(" , ", array));
for(int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];  
}
Console.WriteLine("Измененный массив ");
Console.WriteLine(String.Join(" , ", array));

