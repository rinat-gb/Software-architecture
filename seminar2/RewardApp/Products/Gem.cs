using System;

namespace RewardApp.Products
{
    internal class Gem : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Сундук с алмазами открыт!");
    }
}
