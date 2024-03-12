// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double Adavg(int[] numbers) {
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}
int[] arr = {1,2,3,4,};
double average = Adavg(arr);
Console.WriteLine(average);
