using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
	public class Vehicle
	{
		public double speed;//0
		public Position position;//null
		protected VehileType type;//null

		
		public void Move(int x, int y)
		{
			position = new Position(x, y);
		}

		public void Move(Position pos)
		{
			position = pos;
		}
	}

	public enum VehileType
	{
		Cargo,
		Passenger,
		Military,
	}
}
