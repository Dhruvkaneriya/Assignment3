using System;
using System.Drawing;
using Assignment_3.Eggs;

namespace Assignment_3.Birds
{
	class Bird
	{
		// I will declare broken_egg method for broken eggs.
		public double broken_egg { get; private set; }

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
			// Here I will make new chicken_eggs variable for Egg[] array 
			Egg[] chicken_eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				// I will returns brown egg with size bertween 2 and 4cm.
				chicken_eggs[i] = new Egg(Rand.Next(2, 4), Egg.Colors.brown);
			}
			return chicken_eggs;
		}
	}

	class Ostrich : Bird
	{
		// TODO: Implement this class
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] ostrich_eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				// I will returns brown egg with size bertween 10 and 15cm.
				ostrich_eggs[i] = new Egg(Rand.Next(10, 15), Egg.Colors.speckled);
			}
			return ostrich_eggs;
		}
	}
}
