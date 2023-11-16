using System;

namespace RewardApp.Products
{
    internal class Worms : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Открыт сундук с червяками!");
    }
}
