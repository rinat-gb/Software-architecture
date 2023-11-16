using System;

namespace RewardApp.Products
{
    internal class Sand : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Открыт сундук с песком!");
    }
}
