using System.Text.RegularExpressions;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MtgMatch = ClassLib.MtgMatch;

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
        [DataRow("fred", "-20", 20)]
        [DataRow("karl", "30", 30)]
        [DataRow("karl", "xD", 20)]
        [DataRow("Annegret", "12x3Ffg5", 20)]
        [DataRow("Annegret", "55981364", 55981364)]
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
            var match   = new MtgMatch();
            var player1 = new Player();
            var player2 = new Player();

            //Act
            match.AddPlayerToMatch(player1);
            match.AddPlayerToMatch(player2);

            //Assert
            Assert.AreEqual(2, match.ListOfPlayers.Count);
        }

        [TestMethod]
        [DataRow("","")]
        [DataRow("Bernd","")]
        public void SpielerAusMatchEntfernen(string name, string startingLifeTotal)
        {
            //Arrange
            var match = new MtgMatch();
            var player1 = new Player(name);
            var player2 = new Player(name);

            //Act
            match.AddPlayerToMatch(player1);
            match.AddPlayerToMatch(player2);

            match.RemovePlayerFromMatch(player1);
            match.RemovePlayerFromMatch(player2);

            //Assert
            Assert.AreEqual(0, match.ListOfPlayers.Count);
        }
    }
}