using Contracts.Abstractions;
using Contracts.Cards;

namespace FactoryMethod.Strategy
{
    public class CardStrategy : ICardStrategy
    {
        public IEnumerable<ICard> CommandBuilders { get; }

        public CardStrategy(IEnumerable<ICard> commandBuilders)
        {
            CommandBuilders = commandBuilders ?? throw new ArgumentNullException(nameof(commandBuilders));
        }

        public ICard? GetCard(CardType cardType)
        {
            var commandBuilder = CommandBuilders.FirstOrDefault(dp => dp.Type == cardType);

            return commandBuilder;
        }
    }
}
