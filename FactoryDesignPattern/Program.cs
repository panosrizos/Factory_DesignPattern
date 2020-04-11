
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryMethod.Sample();

        }
    }


    abstract class Printer
    {

        public abstract void GetPrintType();
    }






    class PdfPrinter : Printer
    {


        public override void GetPrintType()
        {
            Console.WriteLine("Prints PDF  ");
        }
    }




    class InkJetPrinter : Printer
    {
        public override void GetPrintType()
        {
            Console.WriteLine("Prints in ink");
        }
    }



    class LazerPrinter : Printer
    {
        public override void GetPrintType()
        {
            Console.WriteLine("Prints with Lazer");
        }
    }





}
