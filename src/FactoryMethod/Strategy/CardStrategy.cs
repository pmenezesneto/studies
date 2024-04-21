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

            ParallelNoWait();

            Console.WriteLine("CalledCommandBuilder");

            return commandBuilder;
        }

        private Task ParallelNoWait()
        {
            Task.Run(async () =>
            {
                await PublishTask();

                Console.WriteLine("Finished all");
            });

            return Task.CompletedTask;
        }

        private async Task PublishTask()
        {
            await Task.Delay(10000);
        }
    }
}
