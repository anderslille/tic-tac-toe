using System;

namespace src
{
    public class TicTacToe
    {
        private string _currentPlayer = "X";

        public TicTacToe()
        {
        }

        public string GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public void PlaceMarkerAt(int v1, int v2)
        {
            if(_currentPlayer == "O")
            {
                _currentPlayer = "X";
            }
            else
            {
                _currentPlayer = "O";
            }
        }
    }
}