using Contracts.Abstractions;
using Contracts.Cards;

namespace FactoryMethod.Strategy
{
    public interface ICardStrategy
    {
        ICard? GetCard(CardType cardType);
    }
}
