using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
        Console.WriteLine("Enter the number of small carpets: ");
        Console.ReadLine();
        int smallCarpets = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of large carpets: ");
        Console.ReadLine();
        int largeCarpets = Convert.ToInt32(Console.ReadLine());

        const double pricePerSmallCarpet = 25.0;
        const double pricePerLargeCarpet = 35.0;
        const double taxRate = 0.06;

        double cost = (smallCarpets * pricePerSmallCarpet) + (largeCarpets * pricePerLargeCarpet);
        double tax = cost * taxRate;
        double totalEstimate = cost + tax;
        Console.WriteLine($"Number of small carpets: {smallCarpets}");
        Console.WriteLine($"Number of large carpets: {largeCarpets}");
        Console.WriteLine($"Price per small carpet: ${pricePerSmallCarpet}");
        Console.WriteLine($"Price per large carpet: ${pricePerLargeCarpet}");
        Console.WriteLine($"Cost: ${cost:F2}");
        Console.WriteLine($"Tax: ${tax:F2}");
        Console.WriteLine($"Total estimate: ${totalEstimate:F2}");
        Console.WriteLine("This estimate is valid for 30 days.");
    }
}
