namespace Gamgid.Models
{
    public interface IGamgidBaseModel
    {
        /// <summary>
        /// Size of pagination to given
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Number of pagination to given
        /// </summary>
        public int PageNumber { get; set; }
    }
}