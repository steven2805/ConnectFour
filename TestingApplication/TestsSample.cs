using System;
using NUnit.Framework;
using ConnectFour;

namespace TestingApplication
{
    
    [TestFixture]
    public class TestsSample
    {
        public GameBoard GameBoard { get; set; }

        [SetUp]
        public void Setup() {
            this.GameBoard = new GameBoard(10, 10);
        }

        //[TearDown]
        //public void Tear() { }


        [Test]
        public void TestGridSize(){
            Assert.AreEqual(this.GameBoard.positions.Count, 10);
        }

        [Test]
        public void TestRowSize(){
            Assert.AreEqual(this.GameBoard.positions[0].Count,10);
        }

        [Test]
        public void checkWining(){
			GameBoard.playmove(0,1);
			GameBoard.playmove(1,1);
			GameBoard.playmove(1,1);
			GameBoard.playmove(2,1);
			GameBoard.playmove(3,1);
            Assert.IsTrue(this.GameBoard.gameLogic.ConditionChecker(this.GameBoard.positions));
        }

        [Test]
        public void checkingDiagonalWinner(){
			GameBoard.playmove(5, 2);
			GameBoard.playmove(5, 2);
			GameBoard.playmove(5, 2);
			GameBoard.playmove(5, 2);
			GameBoard.playmove(5, 2);
			GameBoard.playmove(5, 1);
			GameBoard.playmove(6, 2);
			GameBoard.playmove(6, 2);
			GameBoard.playmove(6, 2);
			GameBoard.playmove(6, 2);
			GameBoard.playmove(6, 1);
			GameBoard.playmove(7, 2);
			GameBoard.playmove(7, 2);
			GameBoard.playmove(7, 2);
			GameBoard.playmove(7, 1);
			GameBoard.playmove(8, 2);
			GameBoard.playmove(8, 2);
			GameBoard.playmove(8, 1);
            Assert.IsTrue(this.GameBoard.gameLogic.ConditionChecker(this.GameBoard.positions));

        }
    }
}
