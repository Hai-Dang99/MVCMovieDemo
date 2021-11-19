using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    public class Young : Person
    {
        [Display(Name ="ID")]
        public string YoungID { get; set; }
        [Display(Name ="Trường")]
        public string University { get; set; }
    }
}