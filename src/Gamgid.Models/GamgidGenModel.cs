using System.Collections.Generic;

namespace Gamgid.Models
{
    public class GamgidGenModel : IGamgidBaseModel
    {
        /// <summary>
        /// Size of pagination to given.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Number of pagination to given.
        /// </summary>
        public int PageNumber { get; set; }
        
        /// <summary>
        /// Sort model with key value properties. This field can be sent from Body also.
        /// </summary>
        public SortModel Sort { get; set; }

        /// <summary>
        /// Multiple sort key and value properties. This field can be sent from Body also.
        /// </summary>
        public List<SortModel> SortFields { get; set; }

        /// <summary>
        /// Search model with key value properties. This field can be sent from Body also.
        /// </summary>
        public SearchModel Search { get; set; }

        /// <summary>
        /// Multiple Search key and value properties. This field can be sent from Body also.
        /// </summary>
        public List<SearchModel> SearchFields { get; set; }
    }
}