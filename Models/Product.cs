﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESA_Terra_Argila.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string Reference { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string Unit { get; set; }

        // Relacionamentos
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }

        public Product()
        {
            ProductMaterials = new HashSet<ProductMaterial>();
            ProductTags = new HashSet<ProductTag>();
        }
    }
}
