using System;

public class ComplexDataTypes
{
	public ComplexDataTypes()
	{
		//Single Dimensional Array
		//a reference type that can store multiple values
		//can be accessed through indexing

		//declaring it
		int[] myArray;

		//initiating as we declare it
		int[] myNewArray = new int[10]; //0-9 used to access

		//indexes start at 0

		//after declaring
		myArray = new int[5]; //0-4
		myArray[0] = 234;
		myArray[1] = 34;
		myArray[2] = 23;
		// myArray[5] = 9; DO NOT DO AS IT OUTSIDE THE ARRAY INDEX SIZE

		//string, chars, bool...whatever type can be stored in an array
		char[] myCharArray = new char[5];
		myCharArray[0] = 'h';
		myCharArray[1] = 'e';
		myCharArray[2] = 'l';
		myCharArray[3] = 'l';
		myCharArray[4] = 'o';

		for(int i =0; i < 5; i++)
        {
			Console.WriteLine(myCharArray[i]);
        }


		//Strings
		//strings are an array of characters
		// we can acess through indexing but cannot change them
		string myString = "hello";
		Console.WriteLine("The last letter of hello is: " + myString[4]);

		//Bad example
		//Do not do myString[0] = "y";
	} 
}
