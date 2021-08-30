using Dare_Full_Stack.Core.Abstraction;
using Dare_Full_Stack.Core.Models;
using Google.Apis.YouTube.v3;
using System.Linq;

namespace Dare_Full_Stack.Core.Services
{
    public class PlayListService : IPlayListService
    {
        public ServiceResultModel<YoutubeServiceModel> GetPlayListItems(string playListId = "", string page = "", int resultsPerPage = 3)
        {
            if (string.IsNullOrWhiteSpace(playListId))
            {
                playListId = "PLG_nqaT-rbpx6wIDr5ufUlbHkg6qB3sxH";
            }
            
            //https://youtube.googleapis.com/youtube/v3/playlistItems?playlistId=PLG_nqaT-rbpx6wIDr5ufUlbHkg6qB3sxH&key=AIzaSyBszT4KEs7WDSz38gfhrH2sD_PosRZSn_g&part=snippet
            var apiKey = "AIzaSyBszT4KEs7WDSz38gfhrH2sD_PosRZSn_g";
            var applicationName = "Dare_Full_Stack";
            var youtubeService = new YouTubeService(new Google.Apis.Services.BaseClientService.Initializer
            {
                ApiKey = apiKey,
                ApplicationName = applicationName,
            });

            var playListRequest = youtubeService.PlaylistItems.List("snippet,contentDetails,status");
            playListRequest.PlaylistId = playListId;
            if (!string.IsNullOrWhiteSpace(page))
            {
                playListRequest.PageToken = page;
            }
            playListRequest.MaxResults = resultsPerPage;

            var result = playListRequest.Execute();
            if (result == null)
            {
                return new ServiceResultModel<YoutubeServiceModel>("Video Api Unavailable");
            }

            if (result.Items == null || result.Items.Count() <= 0)
            {
                return new ServiceResultModel<YoutubeServiceModel>("Playlist does not contain any videos");
            }

            var videos = result.Items
                .Where(v => v.ContentDetails != null)
                .Select(s => new VideoItemModel
                {
                    EmbedUrl = $"https://www.youtube.com/embed/{s.ContentDetails.VideoId}?autoplay=0",
                    Thumbnail = s.Snippet?.Thumbnails?.Default__?.Url,
                    Title = s.Snippet?.Title,
                    Url =  $"http://www.youtube.com/watch?v={s.ContentDetails.VideoId}"
                });

            return new ServiceResultModel<YoutubeServiceModel>
            {
                Item = new YoutubeServiceModel
                {
                    Videos = videos,
                    NextPage = result.NextPageToken,
                    PrevPage = result.PrevPageToken
                },
                Success = true
            };
        }
    }
}
