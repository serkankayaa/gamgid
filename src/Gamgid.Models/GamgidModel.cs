namespace Gamgid.Models
{
    public class GamgidModel : IGamgidBaseModel
    {
        /// <summary>
        /// Size of pagination to given
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Number of pagination to given
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Represents query string for sorting single or multiple fields 
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Represents query string for searching single or multiple fields 
        /// </summary>
        public string SearchKey { get; set; }

        /// <summary>
        /// Represents query string for searching single or multiple fields 
        /// </summary>
        public string SearchValue { get; set; }

        /// <summary>
        /// Represents query string for searching condition
        /// </summary>
        public string SearchCondition { get; set; }
    }
}
