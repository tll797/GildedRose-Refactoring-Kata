using Xunit;
using System.Collections.Generic;
using GildedRoseKata.Updaters;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void StandardItemUpdater_DecreasesQualityAndSellIn()
    { 
        var item = new Item { Name = "Standard Item", SellIn = 5, Quality = 10 };
        var updater = new GenericItemUpdater(item);
         
        updater.Update();
         
        Assert.Equal(9, item.Quality);  
        Assert.Equal(4, item.SellIn); 
    }

    [Fact]
    public void AgedBrieUpdater_IncreasesQualityAndDecreasesSellIn()
    { 
        var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 };
        var updater = new Updater_AgedBrie(item);
         
        updater.Update();
         
        Assert.Equal(11, item.Quality);   
        Assert.Equal(4, item.SellIn);   
    }

    [Fact]
    public void Updater_BackstagePass_UpdatesQualityBasedOnSellIn()
    { 
        var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };
        var updater = new Updater_BackstagePass(item);
         
        updater.Update();
         
        Assert.Equal(13, item.Quality);  
        Assert.Equal(4, item.SellIn);  
    }

    [Fact]
    public void Updater_Sulfuras_MaintainsQualityAndSellIn()
    { 
        var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 };
        var updater = new Updater_Sulfuras(item);
         
        updater.Update();
         
        Assert.Equal(80, item.Quality);  
        Assert.Equal(5, item.SellIn);  
    }
}