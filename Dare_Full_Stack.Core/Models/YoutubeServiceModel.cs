using System;
using System.Collections.Generic;

namespace Dare_Full_Stack.Core.Models
{
    public class YoutubeServiceModel
    {
        public string PlayListId { get; set; }
        public string NextPage { get; set; }
        public string PrevPage { get; set; }
        public IEnumerable<VideoItemModel> Videos { get; set; }
    }
   
}
