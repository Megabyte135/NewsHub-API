﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display order must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
