using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStoreMVC.Models
{
    public class Mobile
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Brand")]
        public string Brand { get; set; }



        [Display(Name = "Price")]
        public int Price{ get; set; }

       


    }
}
