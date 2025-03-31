﻿using System.ComponentModel.DataAnnotations;

namespace ESA_Terra_Argila.Models
{
    public class UserMaterialFavorite
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;

        [Required]
        public int MaterialId { get; set; }
        public Material Material { get; set; } = default!;

        public DateTime CreatedAt { get; set; }
    }

}
