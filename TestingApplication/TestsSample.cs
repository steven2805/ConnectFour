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
        public void TestStuff() {
            Assert.Equals(GameBoard.ToString(), "GameBoard");
        }

        [Test]
        public void TestGridSize(){
            Assert.AreEqual(this.GameBoard.positions.Count, 10);
        }

        [Test]
        public void TestRowSize(){
            Assert.AreEqual(this.GameBoard.positions[0].Count,7);
        }




        [Test]
        public void Pass()
        {
            Console.WriteLine("test1");
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}
