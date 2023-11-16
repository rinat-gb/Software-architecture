using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class PeelingsGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Peelings();
    }
}
