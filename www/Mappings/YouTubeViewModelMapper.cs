using Dare_Full_Stack.Core.Models;
using Umbraco.Core.Mapping;
using www.ViewModels;

namespace www.Mappings
{
    public class YouTubeViewModelMapper : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<YoutubeServiceModel, PlayListViewModel>((source, context) => new PlayListViewModel(), Map);
            mapper.Define<VideoItemModel, YoutubeVideoViewModel>((source, context) => new YoutubeVideoViewModel(), MapVideo);
        }

        private void MapVideo(VideoItemModel source, YoutubeVideoViewModel target, MapperContext arg3)
        {
            target.EmbedUrl = source.EmbedUrl;
            target.Thumbnail = source.Thumbnail;
            target.Title = source.Title;
            target.Url = source.Url;
        }

        private void Map(YoutubeServiceModel source, PlayListViewModel target, MapperContext context)
        {
            target.NextPage = source.NextPage;
            target.PrevPage = source.PrevPage;
            target.PlayListId = source.PlayListId;
            target.Videos = context.MapEnumerable<VideoItemModel, YoutubeVideoViewModel>(source.Videos);
        }
    }
}