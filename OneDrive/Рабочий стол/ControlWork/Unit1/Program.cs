class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива (разделите их пробелом):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' '); 
        string[] resultArray = FilterArray(inputArray);
        Console.WriteLine("Результат:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

static string[] FilterArray(string[] array)
    {   
