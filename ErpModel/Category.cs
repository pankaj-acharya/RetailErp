using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ErpModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public int CatalogueId { get; set; }
        public bool IsActive { get; set; }
    }
}
