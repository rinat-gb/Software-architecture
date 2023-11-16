using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class GemGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Gem();
    }
}
