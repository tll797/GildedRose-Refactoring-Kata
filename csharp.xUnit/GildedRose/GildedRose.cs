using System.Collections.Generic;
using GildedRoseKata.Updaters;

namespace GildedRoseKata;

public class GildedRose  
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    new Updater_AgedBrie(item).Update();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    new Updater_BackstagePass(item).Update();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    new Updater_Sulfuras(item).Update();
                    break;
                default:
                   new GenericItemUpdater(item).Update();
                    break; 
            };
    }
    }

    
}