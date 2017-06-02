using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
	public class Truck : Vehicle
	{
		public double volume;

		public Truck()
		{
			type = VehileType.Cargo;
		}
	}
}
