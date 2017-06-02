using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
	public class F16 : AirVehicle
	{
		public int GunsNumber;

		public F16()
		{
			type = VehileType.Military;
		}
	}
}
