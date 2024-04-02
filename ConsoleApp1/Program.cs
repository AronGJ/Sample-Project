// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;

Console.WriteLine("Hello, World!");

Console.WriteLine("Sample");

Console.WriteLine("Sample2");

var url = "https://store.steampowered.com/search/?filter=topsellers";
var web = new HtmlWeb();
var doc = web.Load(url);
var discountedPrices = doc.DocumentNode.SelectNodes("//div[@class='discount_final_price']");

foreach (var price in discountedPrices)
{
    Console.WriteLine(price.InnerText);

}


Console.ReadLine();


