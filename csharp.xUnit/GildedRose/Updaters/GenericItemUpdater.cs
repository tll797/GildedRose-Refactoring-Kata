using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    public  class GenericItemUpdater : GildedRoseUpdater
    {
        /// <summary>
        /// Update items with names that match no case defintions
        /// </summary>
        /// <param name="item">item to update</param>
        public GenericItemUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            DecreaseQuality();
            if (_Item.SellIn < 0)
                DecreaseQuality();
        }
    }
}
