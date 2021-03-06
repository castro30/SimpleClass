﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassDemo
{
    class Building
    {
        public int area;
        public int occupants;
        public int floors;

        public double AreaPerPerson()
        {
            return area / occupants;
        }

    }

    class BuildingDemo
    {
        static void Main(string[] args)
        {

            // In Main method, create one more object of class “Building” called “office”
            
            Building house = new Building();
            house.area = 2500;
            house.occupants = 4;
            house.floors = 2;
            // House assignments
            Building office = new Building();

            office.area = 4200;
            office.occupants = 25;
            office.floors = 3;
            //Office assignments

            // Defining house and office as a part of Building. 
            // House and office now have access to the Building class. 

            double areaPerPerson; // New type to hold the answer for house.
            double areaPerPersonOffice; // New type to hold the answer for office.

            areaPerPerson = house.AreaPerPerson();
            areaPerPersonOffice = office.AreaPerPerson();


            

            Console.WriteLine(areaPerPerson);
            Console.WriteLine(areaPerPersonOffice);
            
            Console.ReadKey();


        }
    }
}


