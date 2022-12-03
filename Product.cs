using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace SepetSistemi.Models.Entities
{
    [Table(name: "tbl_product")]
    public class Product : BaseEntity
    {
        public string Image { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }
        public int CampaignRatio { get; set; }
        public int TaxRatio { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set;}

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public string Color { get; set; }
        public string Size { get; set; }
        public string SizeMeasurement { get; set; }
        public string Weight { get; set; }
        public string WeightMeasurement { get; set; }
    }
}