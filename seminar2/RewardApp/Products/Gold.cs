using System;

namespace RewardApp.Products
{
    internal class Gold : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Сундук с золотом открыт!");
    }
}
