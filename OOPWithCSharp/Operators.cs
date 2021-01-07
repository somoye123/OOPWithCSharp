using System;

public class Operators
{
	static void Main(string[] args)
	{
		// What are operators?
		// operators are characters that allow for certain action or operations to take place

		//Equals = 
		//assignment
		int myInt = 10;

        //comparing values ==
        if (myInt == 10)
        {
			Console.WriteLine("I'm 10");
        }

        // not equals !=
        if (myInt != 8)
        {
			Console.WriteLine("I'm not 8");
        }

		// +
		myInt = myInt + 2;
		Console.WriteLine(myInt);

		// -
		myInt = myInt - 2;
		Console.WriteLine(myInt);

		// *
		myInt = myInt * 2;
		Console.WriteLine(myInt);
	}
}
