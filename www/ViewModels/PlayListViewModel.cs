using System.Collections.Generic;

namespace www.ViewModels
{
    public class PlayListViewModel
    {
        public string PlayListId { get; set; }
        public string NextPage { get; set; }
        public string PrevPage { get; set; }
        public IEnumerable<YoutubeVideoViewModel> Videos { get; set; }
    }
}