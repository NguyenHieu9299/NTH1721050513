using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTH1721050513.Models
{
    public class Student : Person
    {
        [StringLength(50)]
        [Display (Name = " Trường Đại Học")]
        public string University { get; set; }

        [StringLength(50)]
        [Display(Name = " Địa Chỉ Nhà")]
        public string Address { get; set; }
    }
}