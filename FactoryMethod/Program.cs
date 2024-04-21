using Contracts.Cards;
using Contracts.Requests;
using FactoryMethod.Infra;
using FactoryMethod.Strategy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.Register();

var cardBlack = new CardRequest();
cardBlack.Name = "Test";
cardBlack.CardType = CardType.BLACK;
cardBlack.Number = "12341516";

switch(cardBlack.CardType)
{
    case CardType.BLACK:
        new BlackCard().Create(cardBlack.Name, cardBlack.Number);
        break;
}

var host = builder.Build();
var cardStrategy = host.Services.GetRequiredService<ICardStrategy>();
var cardCreated = cardStrategy.GetCard(cardBlack.CardType);
cardCreated?.Create(cardBlack.Name, cardBlack.Number);

var cardPlatinum = new CardRequest();
cardPlatinum.Name = "Platinum Card";
cardPlatinum.CardType = CardType.PLATINUM;
cardPlatinum.Number = "29488t71788";

var platinumCreated = cardStrategy.GetCard(cardPlatinum.CardType);
platinumCreated?.Create(cardPlatinum.Name, cardPlatinum.Number);

var inexistentCard = new CardRequest();
inexistentCard.Name = "Inexistent";
inexistentCard.CardType = CardType.UNKNOWM;
inexistentCard.Number = "000000000";

var inexistentCardCreated = cardStrategy.GetCard(inexistentCard.CardType);
inexistentCardCreated?.Create(inexistentCard.Name, inexistentCard.Number);

Console.WriteLine("Card Created: {0}, {1}, {2}", cardCreated.Name, cardCreated.Type, cardCreated.Number);

Console.WriteLine("Card Created: {0}, {1}, {2}", platinumCreated.Name, platinumCreated.Type, platinumCreated.Number);

Console.WriteLine("Card Created: {0}, {1}, {2}", inexistentCardCreated.Name, inexistentCardCreated.Type, inexistentCardCreated.Number);

Console.ReadLine();
host.Run();