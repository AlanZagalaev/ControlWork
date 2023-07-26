class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива (разделите их пробелом):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' '); 
        string[] resultArray = FilterArray(inputArray);
