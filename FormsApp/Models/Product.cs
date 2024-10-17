using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Display(Name = "Urun Adı")]
        [Required]

        public string Name { get; set; } = null!;

        [Display(Name = "Fiyat")]
        [Required]
        [Range(0,100000)]
        public Decimal? Price { get; set; }

        [Display(Name = "Resim")]
        
        public string? Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        
        [Display(Name = "Kategori")]
        [Required]
        public int? CategoryId { get; set; }
    }
}