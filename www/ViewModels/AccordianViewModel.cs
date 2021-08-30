using System.Collections.Generic;
using System.Linq;
using Umbraco.Web.PublishedModels;

namespace www.ViewModels
{
    public class AccordianViewModel
    {
        public AccordianViewModel(Accordian accordian)
        {
            Items = accordian?.AccordianItems?.Select(s => new AccordianItemViewModel(s.Content as AccordianItem));
        }
        public IEnumerable<AccordianItemViewModel> Items { get; set; }
    }
}