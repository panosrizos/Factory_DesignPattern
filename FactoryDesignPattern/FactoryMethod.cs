using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    static class FactoryMethod
    {


        static Printer GetPrinter(string type)
        {
            switch (type)
            {
                case "InkJet":
                    return new InkJetPrinter();

                case "Pdf":
                    return new PdfPrinter();
                case "Lazer":
                    return new LazerPrinter();

                default:
                    return new InkJetPrinter();
            }
        }

        public static void Sample()
        {
            Console.Write("What Type do you want? ");
            var type = Console.ReadLine();
            var printer = GetPrinter(type.Trim());

            //sandwich.Ingredients.Add(new Mustard());

            Console.WriteLine($"Here, we have  {printer.GetType().Name}");
            printer.GetPrintType();
            Console.Read();
        }






    }
}
