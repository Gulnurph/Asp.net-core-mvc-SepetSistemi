using SepetSistemi.Models.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace SepetSistemi.Data
{
    public class SepetContext : DbContext
    {
        public SepetContext() : base("Server=.\\sqlexpress; Database=sepet_sistemi; Trusted_Connection=True;")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
    }
}