using Contracts.Requests;

namespace FactoryMethod.Application
{
    public interface ICreateCard
    {
        string Create(CardRequest request);
    }
}
