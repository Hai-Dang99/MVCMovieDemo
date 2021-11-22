using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("HDs")]
    public class HD
    {
        [Key]
        [Display(Name ="ID")]
        public string HDID { get; set; }
        [Display(Name ="Họ và tên")]
        public string HDName { get; set; }
    }
}