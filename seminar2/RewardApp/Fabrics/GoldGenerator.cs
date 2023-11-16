using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class GoldGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Gold();
    }
}
