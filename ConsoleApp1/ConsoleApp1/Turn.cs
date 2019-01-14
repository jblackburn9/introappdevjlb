using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Turn
    {
        private int _PlayerOneResult;
        private int _PlayerTwoResult;
       // private static Die _TheDie = new Die();

        public int PlayerOneResult
        {
            get
            {
                return _PlayerOneResult;
            }
            set
            {
                _PlayerOneResult = value;
                //_TheDie.Roll();
                //_PlayerOneResult = _TheDie.Face;

            }
        }

        public int PlayerTwoResult
        {
            get
            {
                return _PlayerOneResult;
            }
            set
            {
                _PlayerTwoResult = value;
                //_TheDie.Roll();
                //_PlayerTwoResult = _TheDie.Face;
            }
        }

        public Turn()
        {

        }

        public Turn(int player1, int player2)
        {
            PlayerOneResult = player1;
            PlayerTwoResult = player2;
        }
    }
}
