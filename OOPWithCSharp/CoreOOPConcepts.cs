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

		//private data members/methods - can only be accessed in the class
		private int scare_;

		//static data members/methods - apply to the entire class rather than an instance of it
		private int nMonsters_;
	}
	static void Main(string[] args)
	{
	}
}
