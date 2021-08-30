using Dare_Full_Stack.Core.Abstraction;
using Dare_Full_Stack.Core.Constants;
using Dare_Full_Stack.Core.Extensions;
using Dare_Full_Stack.Core.Helpers;
using Dare_Full_Stack.Core.Models;
using System.Linq;
using Umbraco.Core.Services;

namespace Dare_Full_Stack.Core.Services
{
    public class UmbracoPlayListService : IUmbracoPlayListService
    {
        private readonly IContentService _contentService;

        public UmbracoPlayListService(IContentService contentService)
        {
            _contentService = contentService;
        }

        public void StorePlayListVideos(UmbracoPlaylistUpdateModel updateData)
        {
            // this is not working - the video property is stored inside a blocklist item and apparently
            // i would need to get the json parse it update the content and convert it back to the blocklist type
            // i will leave this as is but to keep using the blocklist the method will need more time 

            var node = _contentService.GetById(updateData.NodeId);
            var existingData = node.GetPlayListData();

            if (existingData != null)
            {
                updateData.Data.Videos = existingData.Videos.Concat(existingData.Videos);
            }

            node.SetValue(DareConstants.YoutubePropertyName, CamelCaseSerializer.Serialize(updateData.Data));
            _contentService.SaveAndPublish(node);
        }

    }
}
