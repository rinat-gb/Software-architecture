using System;

namespace RewardApp.Products
{
    internal class Dust : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Открыт пыльный сундук!");
    }
}
