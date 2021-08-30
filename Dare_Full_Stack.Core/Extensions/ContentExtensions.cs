using Dare_Full_Stack.Core.Constants;
using Dare_Full_Stack.Core.Models;
using Newtonsoft.Json;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Core.Models.Blocks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dare_Full_Stack.Core.Extensions
{
    public static class ContentExtensions
    {
        public static YoutubeServiceModel GetPlayListData(this IContent content)
        {
            
            var components = content?.GetValue<BlockListModel>("components");
            var property = components.FirstOrDefault(s => s.Content.ContentType.Alias == "playlistComponent")?.Content;
            return property?.GetPlayListData();
        }
        public static YoutubeServiceModel GetPlayListData(this IPublishedElement element)
        {
            return ConvertToModel(element.Value<string>(DareConstants.YoutubePropertyName));
        }

        public static YoutubeServiceModel GetPlayListData(this IPublishedContent content)
        {
            return ConvertToModel(content.Value<string>(DareConstants.YoutubePropertyName));
        }

        private static YoutubeServiceModel ConvertToModel(string jsonData)
        {
            return JsonConvert.DeserializeObject<YoutubeServiceModel>(jsonData);
        }
    }
}
