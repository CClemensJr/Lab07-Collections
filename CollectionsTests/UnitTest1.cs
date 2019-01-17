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
        public void AddCardToDeck_DeckNotEmpty()
        {
            Card card = new Card();
            card.Suite = "Spades";
            card.Face = "King";

            Deck<Card> deck = new Deck<Card>();
            deck.Add(card);

            Assert.NotEmpty(deck);
        }

        [Fact]
        public void RemoveExistingCardFromDeck_DeckLengthDecreasesByOne()
        {
            Card card = new Card();
            card.Suite = "Spades";
            card.Face = "King";

            Deck<Card> deck = new Deck<Card>();
            deck.Add(card);

            deck.Remove(card);

            Assert.Empty(deck);
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
