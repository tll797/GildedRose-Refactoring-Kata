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

    /* public void UpdateQuality()
     {
         for (var i = 0; i < Items.Count; i++)
         {
             if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
             {
                 if (Items[i].Quality > 0)
                 {
                     if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                     {
                         Items[i].Quality = Items[i].Quality - 1;
                     }
                 }
             }
             else
             {
                 if (Items[i].Quality < 50)
                 {
                     Items[i].Quality = Items[i].Quality + 1;

                     if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                     {
                         if (Items[i].SellIn < 11)
                         {
                             if (Items[i].Quality < 50)
                             {
                                 Items[i].Quality = Items[i].Quality + 1;
                             }
                         }

                         if (Items[i].SellIn < 6)
                         {
                             if (Items[i].Quality < 50)
                             {
                                 Items[i].Quality = Items[i].Quality + 1;
                             }
                         }
                     }
                 }
             }

             if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
             {
                 Items[i].SellIn = Items[i].SellIn - 1;
             }

             if (Items[i].SellIn < 0)
             {
                 if (Items[i].Name != "Aged Brie")
                 {
                     if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                     {
                         if (Items[i].Quality > 0)
                         {
                             if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                             {
                                 Items[i].Quality = Items[i].Quality - 1;
                             }
                         }
                     }
                     else
                     {
                         Items[i].Quality = Items[i].Quality - Items[i].Quality;
                     }
                 }
                 else
                 {
                     if (Items[i].Quality < 50)
                     {
                         Items[i].Quality = Items[i].Quality + 1;
                     }
                 }
             }
         }
     }
    */

}