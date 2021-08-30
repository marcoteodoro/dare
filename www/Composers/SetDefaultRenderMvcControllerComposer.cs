using Dare_Full_Stack.Core.Abstraction;
using Dare_Full_Stack.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.Web;
using www.Controllers;
using www.Mappings;

namespace www.Composers
{
    public class DareComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            RegisterServices(composition);
            RegisterDefaultController(composition);
            RegisterMapper(composition);
        }
        private static void RegisterMapper(Composition composition)
        {
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>().Add<YouTubeViewModelMapper>();
        }

        private static void RegisterDefaultController(Composition composition)
        {
            composition.SetDefaultRenderMvcController<DareMvcController>();
        }

        private static void RegisterServices(Composition composition)
        {
            composition.Register<IPlayListService, PlayListService>();
            composition.Register<IUmbracoPlayListService, UmbracoPlayListService>();
        }
    }
}