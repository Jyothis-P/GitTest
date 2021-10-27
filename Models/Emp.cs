using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GitTest.Models
{
    public class Emp
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Edes { get; set; }
        public DateTime Edoj { get; set; }
    }
}