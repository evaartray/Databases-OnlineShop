using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Bouquet
    {
        public int BouquetId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public Bouquet(int bouquetId, string name, int cost)
        {
            BouquetId = bouquetId;
            Name = name;
            Cost = cost;

        }
    }
}