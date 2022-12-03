using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SepetSistemi.Models.Entities
{
    [Table(name: "tbl_category")]
    public class Category:BaseEntity
    {
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}