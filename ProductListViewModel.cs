using SepetSistemi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SepetSistemi.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductListItem> ProductListItems { get; set; }
        private ProductRepository pRepo = new ProductRepository();
        public ProductListViewModel()
        {
            var products = pRepo.GetRange(x => x.Active && !x.Deleted);
            ProductListItems = from p in products
                               select new ProductListItem
                               {
                                   Id = p.Id,
                                   Name = p.Title,
                                   Description = p.Content,
                                   Image = p.Image,
                                   Brand = p.Brand.Title,
                                   BrandId = p.BrandId,
                                   Category = p.SubCategory.Category.Title,
                                   CategoryId = p.SubCategory.CategoryId,
                                   SubCategory = p.SubCategory.Title,
                                   SubCategoryId = p.SubCategoryId,
                                   CampaignRatio = p.CampaignRatio,
                                   Color = p.Color,
                                   Size = p.Size,
                                   IsInCampaign = p.IsInCampaign,
                                   Price = p.Price,
                                   SizeMeasurement = p.SizeMeasurement,
                                   SKU = p.SKU,
                                   TaxRatio = p.TaxRatio,
                                   Weight = p.Weight,
                                   WeightMeasurement = p.WeightMeasurement
                               };
        }
    }
    public class ProductListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string SKU { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategory { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int BrandId { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }
        public int CampaignRatio { get; set; }
        public int TaxRatio { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string SizeMeasurement { get; set; }
        public string Weight { get; set; }
        public string WeightMeasurement { get; set; }
    }
}