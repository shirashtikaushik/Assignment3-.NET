using System;
using System.Collections.Generic;

internal class Program3
    {
       
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Customer ID: ");
        int customerId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter Units Consumed: ");
        int unitsConsumed = int.Parse(Console.ReadLine());

        // Calculate charges based on the given criteria
        double chargePerUnit = 0.0;

        if (unitsConsumed <= 199)
        {
            chargePerUnit = 1.20;
        }
        else if (unitsConsumed >= 200 && unitsConsumed < 400)
        {
            chargePerUnit = 1.50;
        }
        else if (unitsConsumed >= 400 && unitsConsumed < 600)
        {
            chargePerUnit = 1.80;
        }
        else if (unitsConsumed >= 600)
        {
            chargePerUnit = 2.00;
        }

        // Calculate total charges
        double totalCharges = unitsConsumed * chargePerUnit;

        // Apply surcharge if the total bill exceeds Rs. 400
        if (totalCharges > 400)
        {
            double surcharge = 0.15 * totalCharges;
            totalCharges += surcharge;
        }

        // Ensure minimum bill is Rs. 100
        if (totalCharges < 100)
        {
            totalCharges = 100;
        }

        // Display the electricity bill details
        Console.WriteLine($"Customer IDNO: {customerId}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Unit Consumed: {unitsConsumed}");
        Console.WriteLine($"Amount Charges @Rs. {chargePerUnit:F2} per unit: {totalCharges:F2}");
    }
}

    

