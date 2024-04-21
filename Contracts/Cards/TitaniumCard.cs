using Contracts.Abstractions;

namespace Contracts.Cards
{
    public class TitaniumCard : ICard
    {
        public CardType Type => CardType.TITANIUM;
        public string Name { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public int Limit => 10000;

        public ICard Create(string name, string number)
        {
            Name = name;
            Number = number;

            return this;
        }
    }
}
