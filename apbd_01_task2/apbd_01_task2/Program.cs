// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello there");

double GetAverage(int[] numbers)
{
    double average = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
         average += numbers[i];
    }
    
    return average / numbers.Length;
}


int[] arr = { 1, 2, 3, 4 };

Console.WriteLine(GetAverage(arr));