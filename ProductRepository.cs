using Repository;
using SepetSistemi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SepetSistemi.Data.Repositories
{
    public abstract class SepetGenericRepository<T> : GenericRepository<T> where T : class
    {
        protected SepetGenericRepository() : base(new SepetContext())
        {
        }
    }
    public class ProductRepository : SepetGenericRepository<Product> { }
    public class BrandRepository : SepetGenericRepository<Brand> { }
    public class SubCategoryRepository : SepetGenericRepository<SubCategory> { }
    public class CategoryRepository : SepetGenericRepository<Category> { }
}