using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("LHDs")]
    public class LHD
    {
        [Key]
        public int LHDID { get; set; }
        public string LHDName { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}