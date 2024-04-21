using Contracts.Requests;

namespace FactoryMethod.Services
{
    public interface ICreateCard
    {
        string Create(CardRequest request);
    }
}
