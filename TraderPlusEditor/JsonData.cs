using System.Collections.Generic;

namespace TraderPlusEditor
{
    public class JsonData
    {
        public string Version { get; set; }
        public int EnableAutoCalculation { get; set; }
        public int EnableAutoDestockAtRestart { get; set; }
        public int EnableDefaultTraderStock { get; set; }
        public List<Category> TraderCategories { get; set; }
    }
}
