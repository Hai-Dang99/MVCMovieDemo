using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MVCMovie.Models
{
    [Table("Categois")]
    public class Category
    {
        [Key]
        [Display(Name ="ID")]
        public int CategoryID { get; set; }
        [Display(Name ="Họ và tên")]
        public string CategoryName { get; set; }
        public ICollection<LHD> LHDs { get; set; }
    }
}