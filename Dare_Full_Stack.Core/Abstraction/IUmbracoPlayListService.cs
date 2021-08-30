using Dare_Full_Stack.Core.Models;

namespace Dare_Full_Stack.Core.Abstraction
{
    public interface IUmbracoPlayListService
    {
        void StorePlayListVideos(UmbracoPlaylistUpdateModel updateData);
    }
}