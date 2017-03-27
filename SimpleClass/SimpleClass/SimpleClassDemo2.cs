using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassDemo2
{
    class Building
    {
        // Add two integer data members “occupants” and “floors”
        // within the “Building” class.
        public int area, occupants, floors;

        public void AreaPerPerson()
        {
            Console.WriteLine("The area per person = " + area / occupants);

        }

    }
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            
            // In Main method, create one more object of class “Building” called “office”

            Building house = new Building();
            Building office = new Building();

           
            house.area = 2500;
            house.occupants = 4;
            house.floors = 2;
            house.AreaPerPerson();

            office.area = 4200;
            office.occupants = 25;
            office.floors = 3;
            office.AreaPerPerson();

            
   

            Console.ReadKey();

        }
    }
}
