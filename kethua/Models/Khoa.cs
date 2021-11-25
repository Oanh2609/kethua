using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kethua.Models
{
    public class Khoa
    {
        [Key]
        public string makhoa { get; set; } 
        public string tenkhoa { get; set; }
    }
}