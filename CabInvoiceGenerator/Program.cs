using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n***********************************\nWelcome To Cab Invoice Generator\n***********************************\n");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(0.1, 5); //tc2
            double fare2 = invoiceGenerator.CalculateFare(2.0, 5);//tc1 //tc2
            Console.WriteLine($"Fare : {fare}");
            Console.WriteLine($"Fare2 : {fare2}");
            Console.ReadLine();
        }
    }
}
