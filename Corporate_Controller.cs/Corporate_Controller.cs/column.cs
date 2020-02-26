using System;
using System.Collections.Generic;
using System.Text;


namespace Corporate_Controller.cs
{
    public class Column
    {
        public int Id;
        public int numberOfElevator;
        public int numberOfFloor;
        public int rangeFLoor; 
        public int ByDefault;
        public List<Elevator> elevatorList;
        public List<Button> requestElevatorList;


        public Column(int aId, int aNumberOfElevator, int aNumberOfFloor)
        {
            numberOfFloor = aNumberOfFloor; 
            Id = aId;
            numberOfElevator = aNumberOfElevator;
            //rangeFLoor = aRangeFloor;
            ByDefault = 1;
            
            elevatorList = new List<Elevator>();

            for (int i = 0; i < numberOfElevator; i++)
            {

            Elevator elevator = new Elevator(i, numberOfFloor);
                elevatorList.Add(elevator);
            }    
        } 


        public Elevator FindBestElevator(int requestedFloor, string direction)
        {
            Console.WriteLine("bestElevator");
            Console.WriteLine("direction " + direction);
            Console.WriteLine("floor " + requestedFloor);


            Elevator bestMovingElevator = null;
            int bestMovingTravel = 10000;
            Elevator bestIdleElevator = null;
            int bestIdleTravel = 10000;
            Elevator bestOtherElevator = null;
            int bestOtherTravel = 10000;


            foreach (Elevator elevator in elevatorList)               
            {
                int travel = getTravel(elevator, requestedFloor);
               
                if (elevator.status == "moving" && travel <= bestMovingTravel && elevator.direction == direction)
                {
                    if((elevator.direction == "down" && elevator.currentFloor > requestedFloor) || (elevator.direction == "up" && elevator.currentFloor <= requestedFloor))                    {
                        bestMovingTravel = travel;
                        bestMovingElevator = elevator;
                    }
                }
                else if (elevator.status == "idle" && travel <= bestIdleTravel)
                {
                    bestIdleTravel = travel;
                    bestIdleElevator = elevator;
                }
                else if (travel <= bestOtherTravel)
                {
                    bestOtherTravel = travel;
                    bestOtherElevator = elevator;
                } 
            }
                

            if(bestMovingElevator != null)
            {
                 return bestMovingElevator;
            }
            else if(bestIdleElevator != null)
            {
                return bestIdleElevator;
            }
            else 
            {
                return bestOtherElevator;
            }   
                 
        }




        private int getTravel(Elevator elevator, int requestedFloor)
        {
            return Math.Abs(elevator.currentFloor - requestedFloor);
        }
    
        public List<Button> initOutButtons(int numberOfFloors)
        {

            List<Button> buttons = new List<Button>();
            for (int i = 0; i <= numberOfFloors; i++)
             {
            Console.WriteLine(i);
             }

             return buttons;
        }
    }

}
