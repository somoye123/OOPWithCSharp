﻿using System;

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

		// /
		myInt = myInt / 2;
		Console.WriteLine(myInt);

		//pre-incrementation
		int i = 0;
		Console.WriteLine(++i); // should print 1

		//post-incrementation
		Console.WriteLine(i++); //should still print 1
		Console.WriteLine(i); //should print 2

		// > < greater than and lesser than
		int A = 10;
		int B = 15;
        if (A > B)
        {
			Console.WriteLine("A is bigger");
        }
        else
        {
			Console.WriteLine("B is bigger");
		}

		// >= <= greater than or equal and lesser than
		 B = 15;
		if (A >= B)
		{
			Console.WriteLine("A is bigger");
		}
		else
		{
			Console.WriteLine("B is bigger");
		}

		// +=, -=, *=, /=
		int c = 10;
		c += 2; //prints 12
		c -= 2; // prints 10
		c *= 2; // prints 20
		c /= 2; // prints 10

		//Modulo %
		//remainder
		int D = 21;
		int E = D % 5;
		Console.WriteLine(E);

		//?: tenary operator
		int NewInt = 0;
		// recipient = condition ? true : false;
		NewInt = E > 3 ? 5 : 2;
		Console.WriteLine(NewInt);

		//what are logical operators?
		//these allow for logical operations to take place. These are
		// AND, OR, and NOT
		// &&, ||, !

		bool boolA = true;
		bool boolB = false;
        // &&
        if (boolA && boolB)
        {
			Console.WriteLine("YAY!");
        }
        else
        {
			Console.WriteLine("OH NO!");
        }

		// ||
		if (boolA || boolB)
		{
			Console.WriteLine("YAY!");
		}
		else
		{
			Console.WriteLine("OH NO!");
		}

		// !
		if (boolA && !boolB) //if boolA is true and boolB is false
		{
			Console.WriteLine("YAY!");
		}
		else
		{
			Console.WriteLine("OH NO!");
		}

		//How to make comments //
	}
}
