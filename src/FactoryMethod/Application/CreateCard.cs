using Contracts.Requests;
using FactoryMethod.Strategy;

namespace FactoryMethod.Application
{
    public class CreateCard : ICreateCard
    {
        private readonly ICardStrategy _cardStrategy;
        public CreateCard(ICardStrategy cardStrategy)
        {
            _cardStrategy = cardStrategy ?? throw new ArgumentNullException(nameof(cardStrategy));
        }

        public string Create(CardRequest request)
        {
            var cardFactory = _cardStrategy.GetCard(request.CardType);

            return cardFactory == null ? "Card type not implemented!" : "Card Created";
        }
    }
}
