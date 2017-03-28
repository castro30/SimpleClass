using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassDemo
{
    class Building
    {
        // Add two integer data members “occupants” and “floors”
        // within the “Building” class.
        public int area;
        public int occupants;
        public int floors;

    }

    class BuildingDemo
    {
        static void Main(string[] args)
        {

            // In Main method, create one more object of class “Building” called “office”

            Building house = new Building();
            Building office = new Building();

            // Defining house and office as a part of Building. 
            // House and office now have access to the Building class. 

            double areaPerPerson; // New type to hold the answer for house.
            double areaPerPersonOffice; // New type to hold the answer for office.


            house.area = 2500;
            house.occupants = 4;
            house.floors = 2;
            // House assignments
            office.area = 4200;
            office.occupants = 25;
            office.floors = 3;
            //Office assignments

            areaPerPerson = house.area / house.occupants;

            Console.WriteLine(house.area);

            Console.WriteLine("Area of the house = {0}\n Occupants of the house = {1}\n Floors in the house = {2}\n Area Per person in the house = {3}\n", house.area, house.occupants, house.floors, areaPerPerson);
            Console.ReadKey();

            areaPerPersonOffice = office.area / office.occupants;
            Console.WriteLine(office.area);

            Console.WriteLine("Area of the office = {0}\n Occupants of the office = {1}\n Floors in the office = {2}\n Area Per person in the office = {3}\n", office.area, office.occupants, office.floors, areaPerPersonOffice);
            Console.ReadKey();

        }
    }
}

