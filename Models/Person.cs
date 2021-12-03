using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Display(Name ="ID")]
        public string PersonID { get; set; }
        [Display(Name ="Họ và tên")]
        public string PersonName { get; set; }
        public string Rating { get; set; }
    }
}