using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class StoneGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Stone();
    }
}
