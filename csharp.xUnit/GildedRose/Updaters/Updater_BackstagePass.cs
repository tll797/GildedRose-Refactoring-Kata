using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    public class Updater_BackstagePass : GildedRoseUpdater
    {
        /// <summary>
        /// Update items with name "Backstage passes to a TAFKAL80ETC concert"
        /// </summary>
        /// <param name="item">item to update</param>
        public Updater_BackstagePass(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            IncreaseQuality();

            if (_Item.SellIn < 10)
                IncreaseQuality();

            if (_Item.SellIn < 5)
                IncreaseQuality();

            if (_Item.SellIn < 0)
                _Item.Quality = 0;
        }
    }
}
