using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuEngine;

namespace TestSudokuEngine
{
    [TestClass]
    public class TestBoard
    {
        [TestMethod]
        public void Test_Game_01()
        {
            Board board = new Board();

            board.SetSquareValue(1, 3, 4);
            board.SetSquareValue(1, 5, 5);
            board.SetSquareValue(1, 9, 2);

            board.SetSquareValue(2, 1, 1);
            board.SetSquareValue(2, 4, 2);

            board.SetSquareValue(3, 1, 7);
            board.SetSquareValue(3, 3, 5);
            board.SetSquareValue(3, 4, 1);
            board.SetSquareValue(3, 6, 8);
            board.SetSquareValue(3, 7, 9);
            
            board.SetSquareValue(4, 1, 3);
            board.SetSquareValue(4, 2, 5);
            board.SetSquareValue(4, 3, 2);
            board.SetSquareValue(4, 6, 1);
            board.SetSquareValue(4, 7, 7);
            board.SetSquareValue(4, 8, 8);
            
            board.SetSquareValue(5, 2, 6);
            board.SetSquareValue(5, 5, 7);
            board.SetSquareValue(5, 8, 5);
            
            board.SetSquareValue(6, 2, 8);
            board.SetSquareValue(6, 3, 7);
            board.SetSquareValue(6, 4, 6);
            board.SetSquareValue(6, 7, 4);
            board.SetSquareValue(6, 8, 3);
            board.SetSquareValue(6, 9, 1);
            
            board.SetSquareValue(7, 3, 6);
            board.SetSquareValue(7, 4, 3);
            board.SetSquareValue(7, 6, 7);
            board.SetSquareValue(7, 7, 5);
            board.SetSquareValue(7, 9, 8);
            
            board.SetSquareValue(8, 6, 2);
            board.SetSquareValue(8, 9, 4);
            
            board.SetSquareValue(9, 1, 8);
            board.SetSquareValue(9, 5, 1);
            board.SetSquareValue(9, 7, 3);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }

        [TestMethod]
        public void Test_Game_02()
        {
            Board board = new Board();

            board.SetSquareValue(1, 5, 3);
            board.SetSquareValue(1, 6, 4);
            board.SetSquareValue(1, 8, 9);

            board.SetSquareValue(2, 1, 9);
            board.SetSquareValue(2, 3, 4);
            board.SetSquareValue(2, 5, 5);
            board.SetSquareValue(2, 7, 8);
            board.SetSquareValue(2, 9, 6);

            board.SetSquareValue(3, 2, 6);
            board.SetSquareValue(3, 6, 9);
            board.SetSquareValue(3, 7, 2);

            board.SetSquareValue(4, 2, 2);
            board.SetSquareValue(4, 5, 9);
            board.SetSquareValue(4, 7, 6);
            board.SetSquareValue(4, 8, 4);

            board.SetSquareValue(5, 1, 4);
            board.SetSquareValue(5, 3, 7);
            board.SetSquareValue(5, 5, 1);
            board.SetSquareValue(5, 7, 3);
            board.SetSquareValue(5, 9, 2);

            board.SetSquareValue(6, 2, 5);
            board.SetSquareValue(6, 3, 6);
            board.SetSquareValue(6, 5, 7);
            board.SetSquareValue(6, 8, 1);

            board.SetSquareValue(7, 3, 3);
            board.SetSquareValue(7, 4, 9);
            board.SetSquareValue(7, 8, 2);

            board.SetSquareValue(8, 1, 7);
            board.SetSquareValue(8, 3, 9);
            board.SetSquareValue(8, 5, 2);
            board.SetSquareValue(8, 7, 5);
            board.SetSquareValue(8, 9, 3);

            board.SetSquareValue(9, 2, 1);
            board.SetSquareValue(9, 4, 3);
            board.SetSquareValue(9, 5, 4);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }
    }
}