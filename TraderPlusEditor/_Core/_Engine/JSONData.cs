using System.Collections.Generic;

namespace TraderPlusEditor._Core._Engine
{
    internal class JSONData
    {
        public class JsonData
        {
            public string Version { get; set; }
            public int EnableAutoCalculation { get; set; }
            public int EnableAutoDestockAtRestart { get; set; }
            public int EnableDefaultTraderStock { get; set; }
            public List<Category> TraderCategories { get; set; }
        }

        public class Category
        {
            public string CategoryName { get; set; }
            public List<string> Products { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string Coefficient { get; set; }
            public string MaxStock { get; set; }
            public string TradeQuantity { get; set; }
            public string BuyPrice { get; set; }
            public string SellPrice { get; set; }
            public string DestockCoefficient { get; set; }
        }
    }
}
