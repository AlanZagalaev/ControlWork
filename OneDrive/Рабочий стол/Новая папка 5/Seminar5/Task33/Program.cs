





int [] GetRandomArray()
{
    int[] array = new int[4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] array = GetRandomArray();
Console.WriteLine("vvedi 4islo");
int numberFind = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < array.Length; i++)
{
    if(numberFind == array[i])
    {
        Console.WriteLine("True");
    }
    
}
