using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStoreMVC.Models
{
    public class Stock
    {


        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Model Number")]
        public string modelNumber { get; set; }



        [Display(Name = "Quantity")]
        public int Qty { get; set; }
    }
}
