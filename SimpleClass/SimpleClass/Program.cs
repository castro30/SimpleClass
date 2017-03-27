using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassDemo
{
    class Building
    {
        public int area;

    }
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            //Within the “SimpleClassDemo” namespace
            //define a new class called “Building” with a public integer data member called “area” 

            Building house = new Building();
            house.area = 25;
            Console.WriteLine(house.area);


        }
    }
}
