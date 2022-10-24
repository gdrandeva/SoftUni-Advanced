using System;

namespace Renovators
{
    public class StartUp
    {
        static void Main()
        {

            Catalog catalog = new Catalog("Quality renovators", 1, "Kitchen");
            
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);


            Console.WriteLine(catalog.AddRenovators(renovator)); 
            Console.WriteLine(catalog.AddRenovators(new Renovator(null, "test", 50, 50))); 
            Console.WriteLine(catalog.AddRenovators(new Renovator("Maya", "test", 50, 50))); 
            Console.WriteLine(catalog.AddRenovators(new Renovator("Name", null, 50, 50)));

            Console.WriteLine(catalog.RemoveRenovator("Maya"));

        }
    }
}
