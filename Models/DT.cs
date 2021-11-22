using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("DTs")]
    public class DT
    {
        [Key]
        public int DTID { get; set; }
        public string DTName { get; set; }
        public int LHLID { get; set; }
        public LHL LHL { get; set; }
    }
}