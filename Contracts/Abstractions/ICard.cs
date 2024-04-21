using Contracts.Cards;

namespace Contracts.Abstractions
{
    public interface ICard
    {
        CardType Type { get; }
        string Name { get; }
        string Number { get; }
        int Limit { get; }
        ICard Create(string name, string number);
    }
}
