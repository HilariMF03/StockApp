using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class SaveProductViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del producto")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagUrl { get; set; }
        [Required(ErrorMessage = "Debe colocar el precio del producto")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Debe colocar la categoria del producto")]
        public int CategoryId { get; set; }
    }
}
