using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_05.Shipment
{
    static class DeliveryUtilities
    {
        // Static class: cannot be instantiated, and all its members must be static
        public static void PrintSeparator()
        {
            // For exact output ===
            Console.Write(new string('=', 40));
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.Write("Delivery Center");
            PrintSeparator();
        }
    }
}
