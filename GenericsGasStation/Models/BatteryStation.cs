using GenericsGasStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsGasStation.Models
{
    internal class BatteryStation : IRefuelingStation<ElectricVehicle>
    {
        public int Capacity { get; set ; }

        public void Refuel(List<ElectricVehicle> vehicles)
        {
            foreach (ElectricVehicle v in vehicles)
            {
                Console.WriteLine($"{v.Name} nas been recharged to {v.BatteryCapacity} watts");
            }
        }
    }
}
