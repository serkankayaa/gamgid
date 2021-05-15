namespace Gamgid.Models
{
    public class SearchModel
    {
        /// <summary>
        /// Represents the search key field name.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Represents the search value. The field type is dynamic when what ever comes.
        /// </summary>
        public dynamic Value { get; set; }
    }
}