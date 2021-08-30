using Dare_Full_Stack.Core.Abstraction;
using System.Web.Mvc;
using Umbraco.Core.Mapping;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using www.ViewModels;

namespace www.Controllers
{
    public class DareMvcController : RenderMvcController
    {
        private readonly UmbracoMapper _mapper;
        public DareMvcController(IPlayListService playListService, UmbracoMapper mapper)
        {
            _mapper = mapper;
        }

        public override ActionResult Index(ContentModel model)
        {
            var data = new BaseModel(model.Content, _mapper);
            return base.Index(data);
        }
    }
}