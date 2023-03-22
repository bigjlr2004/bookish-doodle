using GenericsGasStation.Models;
using System;
using System.Collections.Generic;

namespace GenericsGasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          GasVehicle gasRoadster = new GasVehicle();
          GasVehicle gasTruck = new GasVehicle(); 
          GasVehicle gasBoat = new GasVehicle();
            gasRoadster.Name = "Roadster";
            gasRoadster.FuelCapacity = 25;
            gasTruck.Name = "Truckster";
            gasTruck.FuelCapacity = 22;
            gasBoat.Name = "Boatster";
            gasBoat.FuelCapacity= 20;

          ElectricVehicle electricVehicle = new ElectricVehicle();
          ElectricVehicle electricBike = new ElectricVehicle(); 
          ElectricVehicle electricHelicopter = new ElectricVehicle();
            electricVehicle.Name = "Electric Vehicle";
            electricVehicle.BatteryCapacity = 360;
            electricBike.Name = "Electric Bike";
            electricBike.BatteryCapacity = 250;
            electricHelicopter.Name = "Electric Heli";
            electricHelicopter.BatteryCapacity = 450;

            List<Vehicle> vehicles = new List<Vehicle>
            {
                    gasRoadster, gasTruck, gasBoat, electricVehicle, electricBike, electricHelicopter
            };

            int i = 1;
            foreach (Vehicle vehicle in vehicles) 
            {
                Console.WriteLine($"Vehicle # {i}) {vehicle.Name}");
                i++;
            }

            List<GasVehicle> gas = new List<GasVehicle>() { gasRoadster, gasTruck, gasBoat };

            List<ElectricVehicle> electricVehicles = new List<ElectricVehicle>() {  electricVehicle, electricHelicopter, electricBike };
            
            GasStation DeadDino = new GasStation();
            BatteryStation CopperTop = new BatteryStation();
            Console.WriteLine("Electric Recharging");
            CopperTop.Refuel(electricVehicles);
            Console.WriteLine("Gas Station Refueling");
            DeadDino.Refuel(gas);
        }
    }
}
