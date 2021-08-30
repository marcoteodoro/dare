using System;

namespace www.ViewModels
{
    public class AccordianItemViewModel
    {
        public AccordianItemViewModel(Umbraco.Web.PublishedModels.AccordianItem accordianItem)
        {
            Id = accordianItem?.Key;
            Title = accordianItem?.Title;
            Body = accordianItem?.BodyText?.ToString();
        }

        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}