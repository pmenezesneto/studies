using Contracts.Abstractions;
using Contracts.Cards;
using FactoryMethod.Strategy;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Infra
{
    public static class IocConfiguration
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            return services
                .AddTransient<ICardStrategy, CardStrategy>()
                .AddTransient<ICard, BlackCard>()
                .AddTransient<ICard, TitaniumCard>()
                .AddTransient<ICard, PlatinumCard>();
        }
    }
}
