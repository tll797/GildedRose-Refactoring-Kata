using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    public class Updater_Sulfuras : GildedRoseUpdater
    {
        /// <summary>
        /// Update items with name "Sulfuras, Hand of Ragnaros"
        /// </summary>
        /// <param name="item">item to update</param>
        public Updater_Sulfuras(Item item) : base(item) { }

        protected override void UpdateSellIn()
        {
             
        }

        protected override void UpdateQuality()
        {
           
        }

        protected override void AfterUpdate()
        {
            _Item.Quality = 80;
        } 
    }
}
