using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStoreMVC.Models
{
    public class Sale
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Mobile")]
        public string Product{ get; set; }



        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}
