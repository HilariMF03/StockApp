using System.ComponentModel.DataAnnotations;

namespace StockApp.Core.Application.ViewModels.Product
{
    public class SaveCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
