using System;

namespace RewardApp.Products
{
    internal class Stone : ItemReward
    {
        override public void OpenReward() => Console.WriteLine("Открыт сундук полный камней!");
    }
}
