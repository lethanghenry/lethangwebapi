using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testapi.Models;

namespace testapi.Data
{
    public class WebBanHangContext:DbContext
    {
        public WebBanHangContext (DbContextOptions<WebBanHangContext> options):base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<UserProduct> userProducts { get; set; }
    }
}
