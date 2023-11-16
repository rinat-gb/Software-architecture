using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class DustGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Dust();
    }
}
