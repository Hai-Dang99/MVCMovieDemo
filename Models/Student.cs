using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Display(Name ="Mã sinh viên")]
        public string StudentID { get; set; }
        [Display(Name ="Tên sinh viên")]
        public string StudentName { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }
    }
}