using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Q 1

        //(int sum, double average) = GetSumAndAverage();
        //Console.WriteLine($"The sum of 10 numbers is: {sum}");
        //Console.WriteLine($"The average is: {average:F6}");



        // Q 2

        //Console.Write("Input number of terms: ");
        //int Num = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= Num; i++)
        //{
        //    int cube = i * i * i; 
        //    Console.WriteLine($"Number is: {i} and cube of the {i} is: {cube}");
        //}


        // Q 3 
        //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

        //int[] filteredYears = GetYears(years);

        //Console.WriteLine("Years greater than 1950:");
        //foreach (int year in filteredYears)
        //{
        //    Console.WriteLine(year);
        //}


        // Q 4 
        //Console.Write("Enter your age in years: ");
        //int AgeYears = int.Parse(Console.ReadLine());

        //int AgeDay= ConvertAgeToDays(AgeYears);

        //Console.WriteLine($"Your age in days is: {AgeDay}");



        // Q 5

        Console.Write("Enter the number of chickens: ");
        int chickens = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of cows: ");
        int cows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of pigs: ");
        int pigs = int.Parse(Console.ReadLine());

        int Total = CalculateTotal(chickens, cows, pigs);

        Console.WriteLine($"Total number of legs among all animals: {Total}");

    }


    // Q 1
    //static (int, double) GetSumAndAverage()
    //{
    //    int sum = 0;
    //    int count = 10;
    //    int[] numbers = new int[count];

    //    Console.WriteLine("Inter the 10 numbers :");

    //    for (int i = 0; i < count; i++)
    //    {
    //        Console.Write($"Number - {i + 1} : ");
    //        numbers[i] = int.Parse(Console.ReadLine());
    //        sum += numbers[i];
    //    }

    //    double average = (double)sum / count;
    //    return (sum, average);


    // Q 3
    //static int[] GetYears(int[] years)
    //{
    //    return years.Where(year => year > 1950).ToArray();
    //}


    // Q 4
    //static int ConvertAgeToDays(int years)
    //{
    //    return years * 365; 
    //}

    // Q 5
    static int CalculateTotal(int chickens, int cows, int pigs)
    {
        int chickenLegs = chickens * 2; 
        int cowLegs = cows * 4;         
        int pigLegs = pigs * 4;         

        return chickenLegs + cowLegs + pigLegs; 
    }


}



