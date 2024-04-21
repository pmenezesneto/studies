using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Kernel;
using AutoFixture.Xunit2;
using Contracts.Abstractions;
using Contracts.Cards;
using FactoryMethod.Strategy;

namespace FactoryMethodTests
{
    public class AutoNSubstituteData : AutoDataAttribute
    {

        public AutoNSubstituteData() : base(() => new Fixture().Customize(new CardStrategyCustomize()))
        {
        }
    }

    public class CardStrategyCustomize : ICustomization
    {
        private static IList<ISpecimenBuilder> _iocList = new List<ISpecimenBuilder>()
        {
            new TypeRelay(typeof(ICardStrategy), typeof(CardStrategy)),
            new TypeRelay(typeof(ICard), typeof(BlackCard)),
            new TypeRelay(typeof(ICard), typeof(PlatinumCard)),
            new TypeRelay(typeof(ICard), typeof(TitaniumCard))
        };

        public void Customize(IFixture fixture)
        {
            foreach(var ioc in _iocList)
            {
                fixture
                    .Customizations
                    .Add(ioc);
            }
        }
    }
}
