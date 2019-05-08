using System.Text.RegularExpressions;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Match = ClassLib.Match;

namespace MTG.WinCalculator.Tests.UnitTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        [DataRow("", "", 20)]
        [DataRow("", "40", 40)]
        [DataRow("frank", "", 20)]
        [DataRow("karl", "0", 20)]
        [DataRow("karl", "-20", 20)]
        [DataRow("karl", "30", 30)]
        [DataRow("karl", "xD", 20)]
        public void SpielerMitKorrektenWertenErzeugen(string name, string startingLifeTotal, int expectedResult)
        {
            //Arrange & Act
            var player = new Player(name, startingLifeTotal);

            //Assert
            Assert.IsNotNull(player);
            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(expectedResult, player.StartingLifeTotal);
        }

        [TestMethod]
        public void MatchAnlegenUndSpielerHinzufügen()
        {
            //Arrange
            var match   = new Match();
            var player1 = new Player();
            var player2 = new Player();

            //Act
            match.AddPlayerToMatch(player1);
            match.AddPlayerToMatch(player2);

            //Assert
            Assert.AreEqual(2, match.ListOfPlayers.Count);
        }
    }
}