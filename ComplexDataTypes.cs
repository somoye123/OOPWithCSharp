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


		//Enumerables
		//value type
		//used to declare a list of constant ints
		//example
		
		enum Day
		{
			Monday,
			Tuesday,
			//...
		}

		enum Direction
		{
			Left,                    //left, as first item wiil get assigned to 0
			Up,                      //Left =1, Up=2,Right=100,Down=123
			Right,                   //left =1, as first item...the rest will
			Down                     //follow the number...Up would be 2...
		}

	Direction dir = new Direction();
	dir = Direction.Up;

		if(dir == Direction.Left)
        {
			Console.WriteLine("Go Left");
        }else if (dir == Direction.Up)
        {
			Console.WriteLine("Go Up");
		}
		else if (dir == Direction.Right)
        {
			Console.WriteLine("Go Right");
		}
		else if(dir == Direction.Down)
        {
			Console.WriteLine("Go Down");
        }
	} 
}
