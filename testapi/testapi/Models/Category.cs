using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapi.Models
{
    public class Category
    {
        [Key]
        public string idCategory { get; set; }
        public string nameCategory { get; set; }
    }
}
