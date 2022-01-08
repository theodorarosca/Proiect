using System.Collections.Generic;

namespace Proiect.Models
{
    public class Courier
    {
        public int ID { get; set; }
        public string CourierName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
