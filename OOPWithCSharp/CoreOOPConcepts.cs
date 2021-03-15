using System;

public class CoreOOPConcepts
{
	//what are classes?
	//blueprints to creating an object
	// they allow the user to create their own type as objects
	public class Monster
	{
		//what can a class contain
		// data members - constanst/variables
		//methods/functions

		//public class - can be accessed anywhere on this project
		//public data members/methods - can be accessed anywhere the class was instantiated
		public string name_;
		public int size_;
		public const int legs_ = 2;

		//private data members/methods - can only be accessed in the class
		private int scare_;

		//static data members/methods - apply to the entire class rather than an instance of it
		public static int nMonsters_;

		//default constructor -initiated all values
		public Monster()
        {
			name_ = "default";
			size_ = 20;
			scare_ = 20;
			nMonsters_++; //increment number of monsters
        }

		//constructor 
		public Monster(string name,int size, int scare) {
			name_ = name;
			size_ = size;
			scare_ = scare;
			nMonsters_++;
		}

		//methods
		public void print()
        {
			Console.WriteLine(name_);
			Console.WriteLine(size_);
			Console.WriteLine(scare_);
		}
	}
	static void Main(string[] args)
	{
		Monster Dinosour = new Monster();
		//public members
		Console.WriteLine(Dinosour.name_);
		//can be changed
		Dinosour.name_ = "Rex";
		Console.WriteLine(Dinosour.name_);

		// change a const cannot be changed
		// example -- Dinosour.legs_ = 3;

		//private members cannot be accessed here
		// example -- Console.WriteLine(Dinosour.scare_);

		//using non-default constructor
		Monster Dragon = new Monster("Drako", 30, 25);
		Console.WriteLine(Dragon.name_);

		//static check
		Console.WriteLine(Monster.nMonsters_);

		Monster Zombie = new Monster("Zombie",6,8);
		//call print method
		Zombie.print();

	}
}
