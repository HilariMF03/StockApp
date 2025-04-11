﻿namespace Application.ViewModels
{
    public class SaveProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
