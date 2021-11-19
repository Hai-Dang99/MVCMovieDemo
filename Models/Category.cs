using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("Categois")]
    public class Category
    {
        [Key]
        [Display(Name ="ID")]
        public string CategoryID { get; set; }
        [Display(Name ="Họ và tên")]
        public string CategoryName { get; set; }
    }
}