using Dare_Full_Stack.Core.Models;

namespace Dare_Full_Stack.Core.Abstraction
{
    public interface IPlayListService
    {
        ServiceResultModel<YoutubeServiceModel> GetPlayListItems(string playListId = "", string page = "", int resultsPerPage = 3);
    }
}