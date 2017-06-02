using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Log;
using OOP.Vehicles;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			object value = new object();

			int a;//0
			bool bo;//false
			object b;//null 
			string c;//null
			Person p;//null
			List<Person> pep;//null

			var person1 = new Person { FirstName = "Diana", LastName = "Grakova"};
			var person2 = new Person { FirstName = "Viktoria", LastName = "Chvikova" };
			var person3 = new Person { FirstName = "Gleb", LastName = "Zadorojnii" };
			var person4 = new Person { FirstName = "Nikolai", LastName = "Lisniak" };
			var person5 = new Person { FirstName = "Volodymyr", LastName = "Babiychuk"};
			var person6 = new Person { FirstName = "Volodymyr", LastName = "Yarovui" };

			var peopleList = new List<Person>();
			peopleList.Add(person1);
			peopleList.Add(person2);
			peopleList.Add(person3);
			peopleList.Add(person4);
			peopleList.Add(person5);
			peopleList.Add(person6);


			var baseLog = new BaseLog();
			baseLog.AddPerson(person1);
			baseLog.AddPerson(person2);
			baseLog.AddPerson(person3);
			baseLog.AddPerson(person4);
			baseLog.AddPerson(person5);
			baseLog.AddPerson(person6);
			Console.WriteLine(baseLog.ToHtml());
			Console.WriteLine();

			var cl = new CheckListLog();
			cl.AddPerson(person1);
			cl.AddPerson(person2);
			cl.AddPerson(person3);
			cl.AddPerson(person4);
			cl.AddPerson(person5);
			cl.AddPerson(person6);
			Console.WriteLine(cl.ToHtml());
			Console.WriteLine();

			var sl = new SelectListLog();
			sl.AddPeople(peopleList);
			//Console.WriteLine(sl.ToHtml());
			//Console.WriteLine();

			var table = new TableLog();
			table.AddPeople(peopleList);
			//Console.WriteLine(table.ToHtml());
			//Console.WriteLine();

			List<BaseLog> group = new List<BaseLog>();
			group.Add(baseLog);
			group.Add(cl);
			group.Add(sl);
			group.Add(table);

			List<TableLog> group2 = new List<TableLog>();
			group2.Add(table);

			//foreach(var item in group2)
			//{
				//item.AddPeople(...);
				//Console.WriteLine(item.ToHtml());
				//Console.WriteLine();
			//}

			foreach(var item in group)
			{
				//item.AddPerson(...)
				Console.WriteLine(item.ToHtml());
				Console.WriteLine();
			}

			Console.ReadKey();

			var sb = new StringBuilder();
			foreach (var item in group)
			{
				//item.AddPerson(...)
				sb.AppendLine(item.ToHtml());
				sb.AppendLine("<br/>");
			}

			var result = sb.ToString();
			Console.WriteLine(result);

			var truck = new Truck();
			var airBus = new AirBus();
			var vehicle = new Vehicle();
			vehicle.Move(10, 10);
			vehicle.Move(new Position(10, 10));

			Vehicle testREference;

			//test again
			//test repository
			//testagain

			var f16 = new F16();


			TestTypes();
			Console.ReadKey();

			Math.Abs(1234);
		}

		private static void TestTypes()
		{
			House house1 = new House();
			Door doorHouse1 = new Door();
			Material doorMaterial = Material.Metal;
			doorHouse1.material = doorMaterial;

			//второй вариант
			int material = 4;
			doorHouse1.material = (Material)material;

			//третий вариант
			doorHouse1.material = (Material)3;

			Position doorLockPosition = new Position(0, 90);
			//doorLockPosition.x = 0;
			//doorLockPosition.y = 90;

			Lock doorLock = new Lock(Material.Brass);
			//doorLock.material = Material.Brass;
			//doorLock.doorLockPosition = doorLockPosition;
			Lock doorLock1 = new Lock(Material.Brass, doorLockPosition);
			Lock doorLock2 = new Lock(Material.Brass, new Position(0, 90));

			doorLock.position = doorLockPosition;
			doorHouse1.lockType = doorLock;

			house1.door = doorHouse1;


			//----------------------------------------------------------
			Door newDoor = new Door(new Lock(Material.Brass, new Position(0, 90)));
			House newHouse = new House();
			newHouse.door = newDoor;

			CottegeTown cTown = new CottegeTown();
			cTown.houses = new House[1];
			cTown.houses[0] = newHouse;


			House house2 = new House();
		}
	}

	public class CottegeTown
	{
		public House[] houses;//null
	}


	public class House
	{
		//двери
		public Door door;

		//окна
		public Window[] windows;

		public Position position;

		//стены
		//крыша
		//...
	}

	public class Door
	{
		public Material material = Material.Metal;
		public Lock lockType;

		public Door()
		{
			material = Material.Metal;
		}

		public Door(Material material)
		{
			this.material = material;
		}

		public Door(Material material, Lock lockType) : this(material)
		{
			this.lockType = lockType;
		}

		public Door(Lock lockType)
		{
			this.lockType = lockType;
		}
	}

	public enum Material
	{
		Fabric, //0
		Metal, //1
		Plastic, //2
		Gold, //3
		PVC,
		Brass,
	}

	public enum Lokation
	{
		Out,
		Inside,
	}

	public class Lock
	{
		public Material material;//null
		public Position position;//null

		public Lock() {}

		public Lock(Material material)
		{
			this.material = material;
		}

		public Lock(Material material, Position position):this(material)
		{
			//this.material = material;
			this.position = position;
		}
	}

	public class Position
	{
		public readonly int z;
		public int x;//0
		public int y;//0

		public Position()
		{
			z = 5;
			Console.WriteLine("Position. Main Constructor");
		}

		public Position(int posX, int posY): this(posX)
		{
			y = posY;
			Console.WriteLine("Position. Constructor with params");
		}

		public Position(int posX) : this()
		{
			x = posX;
			Console.WriteLine("Position. Constructor with one param");
		}
	}

	public class Window
	{
		public Material material;
		public Position position;
	}
}

