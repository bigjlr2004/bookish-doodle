using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsGasStation.Interfaces
{
    public interface IRefuelingStation <T>
    {
        int Capacity { get; set; }

        void Refuel(List<T> vehicles);
    }
}
