using System;
using System.Drawing;
using Assignment_3.Eggs;

namespace Assignment_3.Birds
{
	class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}

	class Chicken : Bird
	{
		// TODO: Implement this class
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				eggs[i] = new Egg(Rand.Next(2, 4), Egg.Colors.brown);
			}
			return eggs;
		}
	}

	class Ostrich : Bird
	{
		// TODO: Implement this class
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				eggs[i] = new Egg(Rand.Next(10, 15), Egg.Colors.speckled);
			}
			return eggs;
		}
	}
}
