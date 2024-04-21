using Contracts.Abstractions;

namespace Contracts.Cards
{
    public class BlackCard : ICard
    {
        public CardType Type => CardType.BLACK;
        public string Name { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public int Limit => 5000;

        public ICard Create(string name, string number)
        {
            Name = name;
            Number = number;

            return this;
        }
    }
}
