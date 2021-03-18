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

		SwordsMan Somoye = new SwordsMan();
		Somoye.Print();
		Somoye.testFunction();
		Console.WriteLine(Somoye.test_);
		Somoye.Swing();

		StructureExample Mike = new StructureExample("Mike", 10, 15);
		Console.WriteLine(Mike.name_);
		Mike.print();
	}


	// Inheritance
	// class inherits methods and data members from the class above

	//abstract class
	//cannot be instantiated
	// can contain abstract methods but its not required

	public abstract class Character
    {
		public string name_;
		public int speed_;
		public int health_;
		public int test_ = 2;
		
		public abstract void Print();

		public int testFunction()
        {
			test_ *= 2;
			return test_;
        }

		//virtual class
		// can be changed in classes that derive from the base class but not required

		public virtual void Swing()
        {
			Console.WriteLine("SWING1");
        }
	}

	public class SwordsMan: Character
    {
		public SwordsMan()
        {
			name_ = "Somoye";
			speed_ = 10;
			health_ = 100;
        }

        //implementing abstract class we must use ovrride
        public override void Print()
        {
			Console.WriteLine("My name is " + name_);
			Console.WriteLine("and I am " + name_ + "times fast");
			Console.WriteLine("my health is " + health_);
		}

		//Virtual function can be overwritten as well
        public override void Swing()
        {
			Console.WriteLine("I am not going to swing!");
        }
    }
}

//Structures
//similar to classes in the sense that they can have public and private
//data memebers and fucntion

//classes support polymorphism and inheritance and struct dont
//classes are a reference type and strutures are a value type
//data members in classes are by default private and in a strcuture are by default public
//defaulit constrcutors are built into structure while you declare it in classes
//reference types hold a reference to the object in memory

//value type hold their value in memory in the location where they were declared

//example of a structure
public struct StructureExample
{
	public string name_;
	public int scare_;
	public int size_;

	//can also hold constructor
	public StructureExample(string name, int scare,int size)
    {
		name_ = name;
		scare_ = scare;
		size_ = size;
    }

	public void print()
    {
		Console.WriteLine(name_);
		Console.WriteLine(scare_);
		Console.WriteLine(size_);
	}
}