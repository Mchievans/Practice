using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork.Models
{
    public class Lunchbox
    {
        [Key]
        public int LunchId { get; set; }
        public string Food { get; set; }
        public string Drinks { get; set; }
    }
}
