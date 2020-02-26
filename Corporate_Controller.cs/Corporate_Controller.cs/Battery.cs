using System;
using System.Collections.Generic;
using System.Text;


namespace Corporate_Controller.cs
{
     public class Battery
    {

        public int numberOfColumns;
        public int numberOfElevators;
        public int numberOfFloors;
        public int rangeFloor;
        public List<Column> columnList;
        

        public Battery(int aNumberOfColumns, int aNumberOfElevators, int aNumberOfFloors)
        {
            numberOfColumns = aNumberOfColumns;
            numberOfElevators = aNumberOfElevators;
            numberOfFloors = aNumberOfFloors;
            columnList = new List<Column>();

            for(int i = 0; i < aNumberOfColumns; i++)
            {
                Column column = new Column(i, 5, 85);
                columnList.Add(column);
            }
        }

        
        public Column RangeFloor(int RequestedFloor, int targetFloor)
        {
            Column selected = null;

            if ( (RequestedFloor >= 2 && RequestedFloor <= 22) || targetFloor <= 22)
            {
                selected = columnList[0];
            }
            else if ((RequestedFloor >= 23 && RequestedFloor <= 43) || targetFloor <= 43 )
            {
                selected = columnList[1];
            }
            else if ((RequestedFloor >= 44 && RequestedFloor <= 64) || targetFloor <= 64 )
            {
                selected = columnList[2];
            }
            else if ((RequestedFloor >= 65 && RequestedFloor <= 85) || targetFloor <= 85)
            {
                selected = columnList[3];
            }
            
            return selected;

        }
        
    }   

}
