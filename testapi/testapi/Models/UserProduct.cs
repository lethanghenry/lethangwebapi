using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapi.Models
{
    public class UserProduct
    {
        [Key]
        public string idUser{ get; set; }
        public string reviewUser { get; set; }
        public string nameUser { get; set; }
        public string emailUser { get; set; }
    }
}
