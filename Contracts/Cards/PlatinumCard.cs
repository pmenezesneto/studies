using Contracts.Abstractions;

namespace Contracts.Cards
{
    public class PlatinumCard : ICard
    {
        public CardType Type => CardType.PLATINUM;
        public string Name { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public int Limit => 20000;

        public ICard Create(string name, string number)
        {
            Name = name;
            Number = number;

            return this;
        }
    }
}
