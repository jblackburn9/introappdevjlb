using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class die
    {
        //this is the definition of an object
        //it is a conceptual view of the data
        //that will be held by a physical instance of this class

        //data members
        //internal private data storage item
        //private data members cannot be reached directly by the user
        //public data members can be reached directly by the user
        private int _Size;
        private string _Colour;


        //properties
        //an external interface between user and one piece of data within the instance
        //a property has two components
        //  1)the ability to assign a value to the internal data member
        //  2)the ability to return an internal value to the user
        public int Size
        {
            get
            {
                //takes internal values and returns them it to user
                return _Size;
            }
            set
            {
                //takes the supplied user value and place it into 
                //the internal private data member
                //the incoming piece of data is placed into a special
                //variable called value
                _Size = value;
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

        //behaviours (methods)
    }
}
