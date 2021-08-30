using Dare_Full_Stack.Core.Extensions;
using Dare_Full_Stack.Core.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.Blocks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace www.ViewModels
{
    public class BaseModel : ContentModel
    {
        //        List<AccordianItemViewModel> accordianItems = new List<AccordianItemViewModel>
        //        {
        //            new AccordianItemViewModel
        //            {
        //                Id =1,
        //                Title ="title sadas",
        //                Body =@"<h1>At vero eos et</h1>
        //<p> </p>
        //<p>accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa</p>
        //<h2>qui officia deserunt mollitia animi,</h2>
        //<p> </p>
        //<h3>id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio.</h3>
        //<p>Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas <a href='#' title='Home'>assumenda e</a>st,</p>
        //<p><img class='img-accordion' src='/media/0sgk0inw/14272036539_469ca21d5c_h.jpg' alt='' width='500' height='333.4375' data-udi='umb://media/662af6ca411a4c93a6c722c4845698e7' /></p>"
        //            },
        //            new AccordianItemViewModel
        //            {
        //                Id =2,
        //                Title ="titleasdas asd",
        //                Body =" asdasd asdas dasd asdasdasdasd"
        //            },
        //            new AccordianItemViewModel
        //            {
        //                Id =3,
        //                Title ="titleasdsdas asdasdasc wsefflslçdf",
        //                Body ="dçaslkdlçasdlç asçldkaslçdk asçldkaslçkdas dasçldkaslçdkaslç"
        //            }
        //        };

        //private SiteModel siteModel;
        //        private void FakeSiteModel(YoutubeServiceModel videoModel)
        //        {
        //            siteModel = new SiteModel
        //            {
        //                Accordian = new AccordianViewModel { Items = accordianItems },
        //                Carousel = new CarouselViewModel
        //                {
        //                    Items = new List<CarouselItemViewModel>
        //                    {
        //                        new CarouselItemViewModel { Id = 9, Title = "<h1>At vero eos et</h1>", Image = "/media/0sgk0inw/14272036539_469ca21d5c_h.jpg" },
        //                        new CarouselItemViewModel { Id = 8, Title = "<h1>At vero eos et</h1>", Image = "/media/logjhqdj/7371127652_e01b6ab56f_b.jpg" },
        //                        new CarouselItemViewModel { Id = 7, Title = "<h1>At vero eos et</h1>", Image = "/media/kiadaqct/5852022091_87c5d045ab_b.jpg" },
        //                        new CarouselItemViewModel { Id = 6, Title = "<h1>At vero eos et</h1>", Image = "/media/dq5hmn5m/18720470241_ff77768544_h.jpg" }
        //                    }
        //                },
        //                Cards = new List<Card>
        //                {
        //                    new Card{Id =1, Body = @"<h1>At vero eos et</h1>
        //<p> </p>
        //<p>accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa</p>
        //<h2>qui officia deserunt mollitia animi,</h2>
        //<p> </p>
        //<h3>id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio.</h3>
        //<p>Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas <a href='#' title='Home'>assumenda e</a>st,</p>
        //<p><img src='/media/0sgk0inw/14272036539_469ca21d5c_h.jpg' alt='' width='500' height='333.4375' data-udi='umb://media/662af6ca411a4c93a6c722c4845698e7' /></p>
        //<p>omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.</p>", Title = "title card 1"},
        //                    new Card{Id =2, Body = @"<h1>At vero eos et</h1>
        //<p> </p>
        //<p>accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa</p>
        //<h2>qui officia deserunt mollitia animi,</h2>
        //<p> </p>
        //<h3>id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio.</h3>
        //<p>Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas <a href='#' title='Home'>assumenda e</a>st,</p>
        //<p><img src='/media/0sgk0inw/14272036539_469ca21d5c_h.jpg' alt='' width='500' height='333.4375' data-udi='umb://media/662af6ca411a4c93a6c722c4845698e7' /></p>
        //<p>omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.</p>", Title = "title card 2"},
        //                    new Card{Id =3, Body = "Body demo card", Title = "title card 3"},
        //                }
        //            };
        //            siteModel.YoutubeData = videoModel;
        //        }
        private readonly UmbracoMapper _mapper;
        public SiteModel SiteModel { get; set; } = new SiteModel();

        public BaseModel(IPublishedContent model, UmbracoMapper mapper) : base(model) 
        {
            _mapper = mapper;
            BindModel(model);
        }

        private void BindModel(IPublishedContent model)
        {
            switch (model.ContentType.Alias)
            {
                case HomePage.ModelTypeAlias:
                    var components = ((HomePage)model).Components;
                    foreach (var component in components)
                    {
                        BindComponent(component);
                    }
                    break;
                default:
                    break;
            }
        }

        private void BindComponent(BlockListItem model)
        {
            switch (model.Content.ContentType.Alias)
            {
                case Carousel.ModelTypeAlias:
                    SiteModel.Carousel = new CarouselViewModel(model.Content as Carousel);
                    break;
                case Accordian.ModelTypeAlias:
                    SiteModel.Accordian = new AccordianViewModel(model.Content as Accordian);
                    break;
                case Cards.ModelTypeAlias:
                    SiteModel.Cards = new CardsViewModel(model.Content as Cards);
                    break;
                case PlaylistComponent.ModelTypeAlias:
                    SiteModel.YoutubeData = _mapper.Map<PlayListViewModel>(model.Content.GetPlayListData());
                    break;
                default:
                    break;
            }
        }

        public string FrontEndData => CamelCaseSerializer.Serialize(SiteModel);

        
    }
}