namespace StockApp.Core.Application.ViewModels.Product
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductsQuantity { get; set; } //para saber cuantos productos tiene una categoria 
    }
}
