using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    class GenericItemUpdater : GildedRoseUpdater
    {
        public GenericItemUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            DecreaseQuality();
            if (_Item.SellIn < 0)
                DecreaseQuality();
        }
    }
}
