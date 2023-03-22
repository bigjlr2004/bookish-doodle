using GenericsGasStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsGasStation.Models
{
    internal class GasStation : IRefuelingStation<GasVehicle>
    {
        public int Capacity { get; set; }

        public void Refuel(List<GasVehicle> vehicles)
        {

            foreach (GasVehicle v in vehicles)
            {
                Console.WriteLine($"{v.Name} nas been refueled to {v.FuelCapacity} gallons");
            }
        }
    }
}
