using System;

namespace src
{
    public class TicTacToe
    {
        private string _currentPlayer = "X";

        private string _previouseMove = "";

        public TicTacToe()
        {
        }

        public string GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public void PlaceMarkerAt(int row, int col)
        {
            if(_previouseMove == "" + row + col)
            {
                return;
            }

            _previouseMove = "" + row + col;
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