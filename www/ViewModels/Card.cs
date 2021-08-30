using System;
namespace www.ViewModels
{

    public class CardItemViewModel
    {
        public CardItemViewModel(Umbraco.Web.PublishedModels.CardItem cardItem)
        {
            Id = cardItem?.Key;
            Title = cardItem?.Title;
            Body = cardItem?.BodyText?.ToString();
        }

        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}