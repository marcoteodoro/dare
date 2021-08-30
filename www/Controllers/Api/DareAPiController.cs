using Dare_Full_Stack.Core.Abstraction;
using Dare_Full_Stack.Core.Models;
using System.Threading.Tasks;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace www.Controllers.Api
{
    [JsonCamelCaseFormatter]
    public class DareAPiController : UmbracoApiController
    {
        private readonly IPlayListService _playListService;
        private readonly IUmbracoPlayListService _umbracoPlayListService;
        public DareAPiController(IPlayListService playListService, IUmbracoPlayListService umbracoPlayListService)
        {
            _playListService = playListService;
            _umbracoPlayListService = umbracoPlayListService;
        }

        [HttpGet]
        public IHttpActionResult GetVideos(string pageToken, string playListId)
        {
            var result = _playListService.GetPlayListItems(playListId, pageToken);
            if (!result.Success)
            {
                return BadRequest(result.FriendlyErrorMessage);
            }

            Task.Run(() => _umbracoPlayListService.StorePlayListVideos(new UmbracoPlaylistUpdateModel
            {
                NodeId = 1158, // todo send this from frontend
                Data = result.Item
            }));

            return Ok(result.Item);
        }

        [HttpGet]
        public IHttpActionResult LoadPlayList(string playListId)
        {
            var result = _playListService.GetPlayListItems(playListId: playListId);
            if (!result.Success)
            {
                return BadRequest(result.FriendlyErrorMessage);
            }

            return Ok(result.Item);
        }
    }
}