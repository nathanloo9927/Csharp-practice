using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace followalong2.Models
{
    public class ProductModel
    {
        [DisplayName("id number")]
        public int Id { get; set; }
        [DisplayName("product name")]
        public string Name { get; set; }
        [DisplayName("cost to customer")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("what you get")]
        public string Description { get; set; }
    }
}
