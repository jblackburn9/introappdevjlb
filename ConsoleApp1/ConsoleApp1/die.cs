using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Die
    {
        //this is the definition of an object
        //it is a conceptual view of the data
        //that will be held by a physical instance of this class

        //data members
        //internal private data storage item
        //private data members cannot be reached directly by the user
        //public data members can be reached directly by the user
        private int _Sides;
        private string _Colour;

        //create a new instance of the math class Random
        //this instance will be shared by each instance of the class Die
        //this instance will be created when the first instance of Die is created
        private static Random _rnd = new Random();


        //properties
        //an external interface between user and one piece of data within the instance
        //a property has two components
        //  1)the ability to assign a value to the internal data member
        //  2)the ability to return an internal value to the user
        public int Sides
        {
            get
            {
                //takes internal values and returns them it to user
                return _Sides;
            }
            set
            {
                //takes the supplied user value and place it into 
                //the internal private data member
                //the incoming piece of data is placed into a special
                //variable called value
                _Sides = value;
            }
        }

        //auto-implemented properties are just like this
        public int Face
        { get; set; }

        public string Colour
        {
            get
            {
                return _Colour;
            }
            set
            {
                //(value == null) will fail for an empty string
                //(value =="") will fail for a null string
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Colour has no value.");
                }
                else
                {
                    _Colour = value;
                }
            }
        }

        //constructors
        //constructors are optional; default system values get used by default
        //supplying one means that the default can no longer be used
        //can create a constructor that takes any combination of the objects data members&properties to construct
        //but dont make more than are needed because thats ridiculous. two is usually a good number of constructors to make

        //public classname ([list of parameters]) { .... }

        //default constructor emulates the system default constructor by taking no values

        public Die()
        {   
            //this constructor can be empty; system default values would be assigned instead
            //but that doesnt always make sense to do

            //you can directly access a private data member in any place within your class
            _Sides = 6;
            Colour = "White";
            //can use class method in the default
            Roll();
        }

        //greedy constructor typically takes a value for each and all of the objects data members&properties
        //order does not matter
        public Die(int sides, string colour)
        {
            //since this data is coming from an outside source, use a property to save values so as to ensure things get validated
            Sides = sides;
            Colour = colour;
            Roll();
        }

        //behaviours (methods)

        //these are actions that the class can perform
        //the actions may or may not alter data members/auto values
        //the actions could simply take a value(s) from the user and perform some logic operations against them

        //cam be public or private
        
        //method that allows the user to change the number of sides on a die

        public void SetSides (int sides)
        {
            if (sides >= 6 && sides <= 20)
            {
                Sides = sides;
                //when the sides changes, the face value may need to change to be within it
                Roll();
            }
            else
            {
                //optionally 
                //a) throw exception
                //throw new Exception("Invalid value for sides");
                //b) set _Sides to a default value
                Sides = 6;
            }
        }

        public void Roll()
        {
            //no parameters are required for this method as it only uses data existing within the class

            //randomly generate a value for the die based upon the maximum value set forth by the number of sides
            Face = _rnd.Next(1, Sides + 1);

        }
    }
}
