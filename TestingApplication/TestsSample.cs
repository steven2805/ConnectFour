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
            this.GameBoard = new GameBoard(10, 7);
        }

        //[TearDown]
        //public void Tear() { }


        [Test]
        public void TestGridSize(){
            Assert.AreEqual(this.GameBoard.positions.Count, 10);
        }

        [Test]
        public void TestRowSize(){
            Assert.AreEqual(this.GameBoard.positions[0].Count,7);
        }

        [Test]
        public void checkWining(){
			GameBoard.playmove(0);
			GameBoard.playmove(1);
			GameBoard.playmove(1);
			GameBoard.playmove(2);
			GameBoard.playmove(3);
            Assert.IsTrue(this.GameBoard.gameLogic.ConditionChecker(this.GameBoard.positions));
        }
    }
}
