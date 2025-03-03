// See https://aka.ms/new-console-template for more information

double GetAverage(int[] numbers)
{
    double average2 = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
         average2 += numbers[i];
    }
    
    return average2 / numbers.Length;
}


int[] arr = { 1, 2, 3, 4 };

Console.WriteLine(GetAverage(arr));
Console.WriteLine(GetAverage(arr));