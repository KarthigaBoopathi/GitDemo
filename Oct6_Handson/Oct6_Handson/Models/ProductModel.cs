using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct6_Handson.Models
{
    public class ProductModel
    {
        [Required()]
        public int ProductId { get; set; }
        [MaxLength(20, ErrorMessage = "Product Name cannot be greater than 20 characters")]
        [MinLength(2, ErrorMessage = "Prodcut Name should be greater than 2 characters")]
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
    }
}