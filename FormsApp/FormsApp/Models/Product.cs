using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name bilgisi Gerekli bir alan")]
        //istersek error message içinde de tr tanımlayabiliriz
        [Display(Name = "Urun Adı")]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(0,100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }


        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive {  get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }  

    }
}
