using Contracts.Cards;
using Contracts.Requests;
using FactoryMethod.Application;
using FluentAssertions;
using Xunit;

namespace FactoryMethodTests
{
    public class CreateCardTests
    {
        [Theory, AutoNSubstituteData]
        public void WhenTryToCreateCard_NotImplemented_ShouldReturnsNotImplemented(CardRequest cardRequest, CreateCard sut)
        {
            // arrange
            cardRequest.CardType = CardType.UNKNOWM;

            // act
            var response = sut.Create(cardRequest);

            // assert
            response.Should().Be("Card type not implemented!");
        }
    }
}
