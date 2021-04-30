using NUnit.Framework;
using src;

namespace Test
{
    /*
     * 1.The game is played on a grid that's 3 squares by 3 squares.
     * 2.The first player to play will be ‘X’ , while the next player will be‘O’. Players will alternate on putting their marks on the grid.
     * 3.Players cannot play on an already played square. 
     * 4.The first player to get 3 marks in a row (either horizontally, vertically or diagonally) is the winner.
     * 5.When all 9 squaresare full, if no player has 3 marks in a row, the game ends in a tie
     */

    /*
     * hvem sin tur er det
     * 
    * 
    */


    public class TicTacToeShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Return_X_As_First_Player()
        {
            var game = new TicTacToe();
            
            Assert.AreEqual("X", game.GetCurrentPlayer());
        }

        [Test]
        public void Return_O_As_Second_Player()
        {
            var game = new TicTacToe();

            game.PlaceMarkerAt(1, 1);

            Assert.AreEqual("O", game.GetCurrentPlayer());
        }

        [Test]
        public void Return_X_As_Third_Player()
        {
            var game = new TicTacToe();

            game.PlaceMarkerAt(1, 1);
            game.PlaceMarkerAt(1, 0);

            Assert.AreEqual("X", game.GetCurrentPlayer());
        }

    }
}