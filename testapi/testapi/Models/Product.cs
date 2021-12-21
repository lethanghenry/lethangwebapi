using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapi.Models
{
    public class Product
    {
        [Key]
        public string idProduct { get; set; }
        public string nameProduct { get; set; }
        public string pictureProduct { get; set; }
        public int priceProduct { get; set; }
        public int discountProduct { get; set; }
        public string decriptionProduct { get; set; }
        public string weightProduct { get; set; }
        public string dimensionsProduct { get; set; }
        public int rateProduct { get; set; }
        public int qualityProduct { get; set; }
        public string idCategory { get; set; }
        public string idUser{ get; set; }
    }
}
