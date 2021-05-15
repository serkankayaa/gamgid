namespace Gamgid.Models
{
    public class SortModel
    {
        /// <summary>
        /// Represents the sort key field name.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Represents the sort value. The field type is dynamic when what ever comes.
        /// </summary>
        public dynamic Value { get; set; }
    }
}