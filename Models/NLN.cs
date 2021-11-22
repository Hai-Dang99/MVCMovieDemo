using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    public class NLN : HD
    {
        [Display(Name ="ID")]
        public string NLNID { get; set; }
        [Display(Name ="Trường")]
        public string University { get; set; }
    }
}