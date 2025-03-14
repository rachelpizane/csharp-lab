using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogName
{
	public class DogCanine
	{
        public string Name { get; }

        public int Age { get; set; } = 0;

		public const string Species = "Canis lupus familiaris";

		private string _owner;

		public string Owner
		{
			get { return _owner; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					Console.WriteLine("Owner name is empty.");
				_owner = value;
			}
		}
		public DogCanine(string name, string owner = "Unknown")
		{
			Name = name;
			_owner = owner;
			Console.WriteLine($"A DogCanine object named {Name} has been created. Owner: {Owner}");
		}


		public string GetCategory()
		{
			return Age >= 2 ? "Adult" : "Young";
		}

		public void EmitSound()
		{
			Console.WriteLine($"{Name} is barking");
		}

		public void Eat()
		{
			Console.WriteLine($"{Name} is eating.");
		}

		public void Eat(string food)
		{
			Console.WriteLine($"{Name} is eating {food}.");
		}
	}

}