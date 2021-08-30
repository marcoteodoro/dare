using System.Collections.Generic;
using System.Linq;
using Umbraco.Web.PublishedModels;

namespace www.ViewModels
{
    public class CardsViewModel
    {
        public CardsViewModel(Cards cards)
        {
            Items = cards?.AccordianItems?.Select(s => new CardItemViewModel(s.Content as CardItem));
        }
        public IEnumerable<CardItemViewModel> Items { get; set; }
    }
}