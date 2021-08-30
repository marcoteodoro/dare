using System.Collections.Generic;
using System.Linq;


namespace Umbraco.Web.PublishedModels.ViewModel
{
    public class Carousel
    {
        public Carousel(PublishedModels.Carousel umbracoModel)
        {
            Items = umbracoModel.Items.Select(i => new CarouselItem(new PublishedModels.CarouselItem(i.Content)));
        }
        public IEnumerable<CarouselItem> Items { get; private set; }
    }

    public class CarouselItem
    {
        public CarouselItem(PublishedModels.CarouselItem umbracoModel)
        {
            Image = umbracoModel.Image.Url();
            Text = umbracoModel.Text.ToString();
        }

        public string Image { get; private set; }
        public string Text { get; private set; }
    }
}

namespace Umbraco.Web.PublishedModels
{
    public partial class Carousel
    {
        public string ToJson() 
        {
            return string.Empty;
        }
    }
}
