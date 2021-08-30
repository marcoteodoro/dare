using System.Collections.Generic;
using System.Linq;
using Umbraco.Web.PublishedModels;
namespace www.ViewModels
{
    public class CarouselViewModel
    {
        public CarouselViewModel(Carousel carousel)
        {
            Items = carousel?.Items?.Select(s => new CarouselItemViewModel(s.Content as CarouselItem));
        }
        public IEnumerable<CarouselItemViewModel> Items { get; set; }
    }
}