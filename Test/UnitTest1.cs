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
        public void Place_X_On_First_Move()
        {
            // arrange
            var game = new TicTacToe();
            // act
            var row = 1;
            var col = 1;
            game.PlaceMarkerAt(row, col);
            //assert
            Assert.AreEqual("X", game.GetMarkerAt(row, col));
        }
    }
}