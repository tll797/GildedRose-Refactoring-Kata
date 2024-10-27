using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    public abstract class GildedRoseUpdater
    {
        readonly Item Item;

        const int MaxQuality = 50;
        const int MinQuality = 0;

        protected GildedRoseUpdater(Item item)
        {
            Item = item;
        }

        public virtual void Update()
        {
            UpdateSellIn();
            UpdateQuality();
            AfterUpdate();
        }

        protected virtual void UpdateSellIn()
        {
            Item.SellIn--;
        }

        protected abstract void UpdateQuality();

        protected virtual void AfterUpdate()
        {
            if (Item.Quality < MinQuality)
                Item.Quality = MinQuality;
            if (Item.Quality > MaxQuality)
                Item.Quality = MaxQuality;
        }

        protected void DecreaseQuality(int amount = 1)
        {
            Item.Quality -= amount;
        }

        protected void IncreaseQuality(int amount = 1)
        {
            Item.Quality += amount;
        }
    }
}
