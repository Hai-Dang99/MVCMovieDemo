using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MVCMovie.Models
{
    [Table("LHLs")]
    public class LHL
    {
        [Key]
        [Display(Name ="ID")]
        public int LHLID { get; set; }
        [Display(Name ="Họ và tên")]
        public string LHLName { get; set; }
        public ICollection<DT> DTs { get; set; }
    }
}