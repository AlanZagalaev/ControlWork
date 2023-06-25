// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = {3.22, 4.2, 1.15, 77.15, 65.2};

// double diff = 0;
double max = numbers[0];



double min = numbers[0];

for(int d = 0; d < numbers.Length; d++)
    {
        if(numbers[d] > max) 
        {
            max = numbers[d];
        }
        if(numbers[d] < min)
        {
            min = numbers[d];
        }
        
    }
double diff = max - min;
Console.WriteLine($"{max} - {min} = {diff}");