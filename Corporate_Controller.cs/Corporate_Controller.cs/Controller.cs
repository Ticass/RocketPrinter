using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_Controller.cs
{
    public class Controller
    {
        public int numberOfFloors;
        public int numberOfColumns;
        public int numberOfElevators;
        public Battery battery;

        public Controller(int aNumberOfFloors, int aNumberOfColumns, int aNumberOfElevators)
        {
            numberOfColumns = aNumberOfColumns;
            numberOfElevators = aNumberOfElevators;
            numberOfFloors = aNumberOfFloors;
            battery = new Battery(aNumberOfColumns, aNumberOfElevators, aNumberOfFloors);

        }
        

        public Elevator RequestElevator(int numberOfFloors, string direction, int target)
         {
            Console.WriteLine("Request elevator to floor : " + numberOfFloors);           
            Column column = battery.RangeFloor(numberOfFloors, target);
            Elevator elevator = column
                .FindBestElevator(numberOfFloors, direction).moveToRequestedFloor(numberOfFloors);
            Console.WriteLine("Column #:" + column.Id);
            


            return elevator;
           
        }
}
}
