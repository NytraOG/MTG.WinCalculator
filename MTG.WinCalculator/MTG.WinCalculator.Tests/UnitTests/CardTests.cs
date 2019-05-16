using System;
using System.Collections.Generic;
using System.Linq;
using ClassLib.Cards;
using ClassLib.Environments;
using ClassLib.Interfaces;
using ClassLib.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MTG.WinCalculator.Tests.UnitTests
{
    [TestClass]
    public class CardTests
    {
        private DeckManager deckManager;
        private Deck        deck;
        private BaseCard    card;

        [TestInitialize]
        public void Init()
        {
            deckManager = new DeckManager();
            deck        = new Deck();
            card        = new BaseCard();
        }

        [DataRow(4)]
        [DataRow(60)]
        [TestMethod]
        public void AddCardsToDeck_AmountOfCardsToBeCreated_CountOfCards(int amountToAdd)
        {
            //Act
            deckManager.AddCardsToDeck(amountToAdd, card, deck);

            //Asser
            Assert.IsNotNull(deck);
            Assert.IsTrue(deck.Cards.Any());
            Assert.AreEqual(amountToAdd, deck.Cards.Count);
        }

        [DataRow((0))]
        [DataRow((-4))]
        [DataRow((61))]
        [DataRow((2938047))]
        [TestMethod]
        public void AddCardsToDeck_InvalidAmountOfCards_Exception(int amountToAdd)
        {
            //Act & Assert
            Assert.ThrowsException<Exception>(() => deckManager.AddCardsToDeck(amountToAdd, card, deck));
        }
    }
}
