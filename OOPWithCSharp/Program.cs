using System;

namespace OOPWithCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			// variables are declared once and can be changed later ono

			// Naming of variables or constant start with a letter
			// followed by a number or an underscore(_)
			int myInt = 1;
			int my_Int = 2;
			int myInt1 = 3;

			// constant are declared once and can not be changed later on
			const int A_CONST_INT = 100;

			// Primitive Data Types

			//interger
			// ints by default are 32 bits
			// can hold numbers from -2,147,483,648 to 2,147,483,648
			// by default signed(hold negative numbers)
			int anInt = 1;
			const int THE_CONST_INT = 2;

			//---------------------------------------------------------

			//byte
			//8 bit versions of an Int
			//unsigned by default
			//range from 0 to 255
			byte myByte = 23;
			const byte MY_CONST_BYTE = 200;

			//short
			//16 bit versions of an Int
			//signed by default
			//range from -32,768 to 32,767
			short myShort = 23000;
			const short MY_CONST_SHORT = -32000;

			//long
			//64 bit versions of an Int
			//range from -9.2*10^18 to 9.2*10^18
			long myLong = 2333344543323;
			const long MY_CONST_LONG = 200443322334343;

			//---------------------------------------------------------
			// unsigned version

			//uint, ulong, ushort
			uint myUint = 33333;
			ulong myUlong = 33333;
			ushort myUshort = 33333;

			//---------------------------------------------------------
			//signed version of a byte
			//sbyte
			//range from -128 to 127 
			sbyte mySbyte = -120;


			//float
			// ints by default are 32 bits
			// can hold numbers from -3.4*10^38 to 3.4*10^38
			// ends with f otherwise it will assume it a double
			// accurate to 7 decimal units
			float aFloat = 2.5634523f;
			const float MY_FLOAT = 2.1425f;

			//double
			// double by default are 64 bits
			// accurate to 15-16 decimal units
			double aDouble = 2.56345234;
			const double MY_DOUBLE = 2.1425;

			//char
			//they hold a value at a time
			//letter to symbol
			char myChar = 'a';
			const char MY_CONST_CHAR = '-';

			//boolean
			//bool holds a value of true or false
			bool myBool = true;
			const bool MY_CONST_BOOL = false;

            //overflowing is when you try to assign a type a value too large for the container
            //Example sbyte myOverflow = 129;

            //Scope refers to the access level of values
            int testInt = 10;
            if (testInt == 10)
            {
				Console.WriteLine(testInt);
				Console.WriteLine("I'm 10");
				testInt = 25;
				Console.WriteLine(testInt);
				int newInt = -1;

				bool myNewBool = true;
                if (myNewBool)
                {
					newInt = -10;
					Console.WriteLine(newInt);

				}
			}
			// the newInt variable update would throw an error as newInt is not in scope anymore
			//newInt = 20;
		}
	}
}
