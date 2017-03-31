using System;
namespace SimpleMethodCall
{
    // Summary
    // Class with data members x and y, specifying coordinates
    //Summary
    class Point
    {
        //data members
        private int xValue;
        private int yValue;

        // summary
        // Class SimpleMethodMain which uses the class Point
        // summary

        public void Accept()
        {
            Console.WriteLine("Enter the coordinates - ");
            xValue = Convert.ToInt32(Console.ReadLine());
            yValue = Convert.ToInt32(Console.ReadLine());
            return;
        }

        ///<summary>
        ///Method to display data members
        ///</summary>

        public void Display()
        {
            Console.WriteLine("The coordinates are  - ");
            Console.WriteLine("{0},{1}", xValue, yValue);
            return;
        }
    }

    public class SimpleMethod
    {
        // summary
        // The main entry point for the application.
        // summary
        public static void Main()
        {


            Point myPoint = new Point();
            myPoint.Accept();
            myPoint.Display();

            /* Point myPoint = new Point();
             Console.WriteLine("The coordinates are  - ");
             myPoint.xValue = 10;
             myPoint.yValue = 15;
             Console.WriteLine("{0},{1}", myPoint.xValue, myPoint.yValue);
             Console.ReadLine();
             return; */

            Console.ReadKey();
        }
    }
}