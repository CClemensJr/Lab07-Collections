using System;
using Xunit;
using Collections.Classes;

namespace CollectionsTests
{
    public class CardTests
    {
        [Fact]
        public void SetCardSuiteProperty_ReturnsSuiteProperty()
        {
            Card card = new Card();
            card.Suite = _Suite.Spades;

            Assert.Equals(Spades, card.Suite);
        }

        [Fact]
        public void ShouldHaveSuite()
        {

        }

        [Fact]
        public void ShouldNotHaveInvalidSuite()
        {

        }

        [Fact]
        public void ShouldHaveFace()
        {

        }

        [Fact]
        public void ShouldNotHaveInvalidFace()
        {

        }
    }


    public class DeckTests
    {
        [Fact]
        public void ShouldCreateADeck()
        {

        }

        [Fact]
        public void ShouldAddCardsToDeck()
        {

        }

        [Fact]
        public void ShouldSubtractCardsFromDeck()
        {

        }

        [Fact]
        public void ShouldSubtractCardFromDeckIfExists()
        {

        }

        [Fact]
        public void ShouldNotSubtractCardFromDeckIfNotExists()
        {

        }

        [Fact]
        public void ShouldGetNumberCardsInADeck()
        {

        }

    }

}
