using System;


namespace Corporate_Controller.cs
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Controller controller = new Controller(85, 4, 20);
            controller.battery.columnList[1].elevatorList[0].currentFloor = 1;  
            controller.battery.columnList[1].elevatorList[0].status = "moving";
            controller.battery.columnList[1].elevatorList[0].direction = "up";
            controller.battery.columnList[1].elevatorList[0].requestFloorList.Add(24);

            controller.battery.columnList[1].elevatorList[1].currentFloor = 23; 
            controller.battery.columnList[1].elevatorList[1].status = "moving";
            controller.battery.columnList[1].elevatorList[1].direction = "up";
            controller.battery.columnList[1].elevatorList[1].requestFloorList.Add(28);

            controller.battery.columnList[1].elevatorList[2].currentFloor = 33; 
            controller.battery.columnList[1].elevatorList[2].status = "moving";
            controller.battery.columnList[1].elevatorList[2].direction = "down";
            controller.battery.columnList[1].elevatorList[2].requestFloorList.Add(1);

            controller.battery.columnList[1].elevatorList[3].currentFloor = 40; 
            controller.battery.columnList[1].elevatorList[3].status = "moving";
            controller.battery.columnList[1].elevatorList[3].direction = "down";
            controller.battery.columnList[1].elevatorList[3].requestFloorList.Add(24);


            controller.battery.columnList[1].elevatorList[4].currentFloor = 42;
            controller.battery.columnList[1].elevatorList[4].status = "moving";
            controller.battery.columnList[1].elevatorList[4].direction = "down";
            controller.battery.columnList[1].elevatorList[4].requestFloorList.Add(1);
            //controller.RequestElevator(02, "up");


            Elevator bestElevator = controller
               .RequestElevator(1, "up", 36) 
               .moveToRequestedFloor(36);
          
            Console.WriteLine("best elevator: " + bestElevator.ID );
            Console.ReadLine();

        }
    }
}
