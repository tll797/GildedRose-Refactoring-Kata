using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Updaters
{
    public abstract class GildedRoseUpdater
    {
        protected readonly Item _Item;

        const int MaxQuality = 50;
        const int MinQuality = 0;

        protected GildedRoseUpdater(Item item)
        {
            _Item = item;
        }

        public virtual void Update()
        {
            UpdateSellIn();
            UpdateQuality();
            AfterUpdate();
        }

        protected virtual void UpdateSellIn()
        {
            _Item.SellIn--;
        }

        protected abstract void UpdateQuality();

        protected virtual void AfterUpdate()
        {
            if (_Item.Quality < MinQuality)
                _Item.Quality = MinQuality;
            if (_Item.Quality > MaxQuality)
                _Item.Quality = MaxQuality;
        }

        protected void DecreaseQuality(int amount = 1)
        {
            _Item.Quality -= amount;
        }

        protected void IncreaseQuality(int amount = 1)
        {
            _Item.Quality += amount;
        }
    }
}
