using System;
using Umbraco.Web.PublishedModels;

namespace www.ViewModels
{
    public class CarouselItemViewModel
    {
        public CarouselItemViewModel(CarouselItem carouselItem)
        {
            if (carouselItem != null)
            {
                Id = carouselItem.Key;
                Title = carouselItem.Text?.ToString();
                Image = carouselItem.Image?.Url;
            }
        }
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}