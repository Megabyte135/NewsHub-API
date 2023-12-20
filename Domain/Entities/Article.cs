using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain.Entities
{
    public class Article : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public string Image { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string PreviewText { get; set; }
        [Required]
        [DisplayName("Created")]
        public DateTime CreationDate { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
