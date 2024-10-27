using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
   
    public class Updater_AgedBrie : GildedRoseUpdater
    {
        /// <summary>
        /// Update items with name "Aged Brie"
        /// </summary>
        /// <param name="item"></param>
        public Updater_AgedBrie(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            IncreaseQuality();
            if (_Item.SellIn < 0)
                IncreaseQuality();
        }
    }
}
