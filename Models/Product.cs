using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Display(Name ="Mã sản phẩm")]
        public string ProductID { get; set; }
        [Display(Name ="Tên sản phẩm")]
        public string ProductName { get; set; }
        [Display(Name ="Giá")]
        public string UnitPrice { get; set; }
        [Display(Name ="Sô lượng")]
        public string Quantity { get; set; }
    }
}