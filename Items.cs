using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
    }
}
