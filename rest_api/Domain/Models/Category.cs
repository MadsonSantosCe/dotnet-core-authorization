using System.Collections.Generic;

namespace rest_api.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
