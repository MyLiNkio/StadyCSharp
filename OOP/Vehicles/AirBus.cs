using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
	public class AirBus : AirVehicle
	{
		public int passengersNumber;

		public AirBus()
		{
			type = VehileType.Passenger;
		}
	}
}
