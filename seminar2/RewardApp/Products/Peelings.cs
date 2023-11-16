using System;

namespace RewardApp.Products
{
    internal class Peelings : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Открыт сундук с картофельными очистками!");
    }
}
