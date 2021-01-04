﻿using System;

namespace OOPWithCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			// variables are declared once and can be changed later on

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
		}
	}
}
