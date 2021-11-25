using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kethua.Models
{
    public class Lop
    {
        [Key]
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string makhoa { get; set; }
        
        [ForeignKey("makhoa")]
        public virtual Khoa Khoa { get; set; }
           
       

    }
}