using System;
using System.Collections.Generic;
using System.Text;


namespace Corporate_Controller.cs
{
    public class Elevator
    {
        public int ID;
        public int numberOfFLoor;
        public string status;
        public string direction;
        public string door;
        public int currentFloor;
        public List<int> requestFloorList;
        public Elevator(int aID, int aNumberOfFLoor)
        {
            numberOfFLoor = aNumberOfFLoor;
            ID = aID;
            status = "idle";
            direction = "up";
            door = "close";
            currentFloor = 1;
            requestFloorList = new List<int>();
        }



        public Elevator moveToRequestedFloor(int requestedFloor)
        {
            requestFloorList.Add(requestedFloor);
            
            if (direction == "up") requestFloorList.Sort((a, b) => a.CompareTo(b));
            else if (direction == "down") requestFloorList.Sort((a, b) => -1 * a.CompareTo(b));

            while (requestFloorList.Count > 0)
            {
                if (requestFloorList[0] == currentFloor)
                {
                    openDoor();
                    requestFloorList.RemoveAt(0);
                    closeDoor();
                }
                else if (requestFloorList[0] < currentFloor)
                {
                    moveDown();
                }
                else if (requestFloorList[0] > currentFloor)
                {
                    moveUp();
                }
            }
            return this;
        }

        public List<Button> initInsideButtons(int numberOfFloors)
        {

            List<Button> buttons = new List<Button>();
            for (int i = 0; i <= numberOfFloors; i++)
            {
                Console.WriteLine(i);
            }

            return buttons;
        }

        public void moveDown()
        {
                currentFloor = currentFloor - 1;

                Console.WriteLine("the elevator number " + this.ID + " is going down!");
                Console.WriteLine("the elevator number " + this.ID + " is at floor number " + this.currentFloor);
              


        }
        public void moveUp()
        {

                currentFloor = currentFloor + 1;


                Console.WriteLine("the elevator number " + this.ID + " is going up!");
                Console.WriteLine("the elevator number " + this.ID + " is at floor number " + this.currentFloor);
                

        }
        public void openDoor()
        {
            door = "opened";
            Console.WriteLine("open door");
            Console.WriteLine("door state: " + door);
            
        }
        public void closeDoor()
        {
            door = "closed";
            Console.WriteLine("close door");
            Console.WriteLine("door state: " + door);
        }
    }
}
