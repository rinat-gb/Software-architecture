using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class SandGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Sand();
    }
}
