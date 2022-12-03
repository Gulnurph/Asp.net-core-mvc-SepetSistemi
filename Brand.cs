using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SepetSistemi.Models.Entities
{
    [Table(name: "tbl_brand")]
    public class Brand : BaseEntity
    {
        public string Logo { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}