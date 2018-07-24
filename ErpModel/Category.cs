using System;
using System.Collections.Generic;

namespace ErpModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public int CatalogueId { get; set; }
    }
}
