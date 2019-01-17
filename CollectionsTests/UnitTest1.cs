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

            card.Suite = "Spades";

            Assert.Equal("Spades", card.Suite);
        }

        [Fact]
        public void SetCardFaceProperty_ReturnsFaceProperty()
        {
            Card card = new Card();

            card.Face = "King";

            Assert.Equal("King", card.Face);
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
