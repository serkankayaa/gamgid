namespace Gamgid.Paging.Const
{
    public static class PagingConsts
    {
        /// <summary>
        /// Provides search operation for equality  
        /// </summary>
        public new const string Equals = "==";

        /// <summary>
        /// Provides search operation for not equality field
        /// </summary>
        public const string NotEquals = "!=";

        /// <summary>
        /// Provides search operation for greater than excepted value
        /// </summary>
        public const string GreaterThan = ">";

        /// <summary>
        /// Provides search operation for less tan excepted value
        /// </summary>
        public const string LessThan = "<";

        /// <summary>
        /// Provides search operation for greater than or equality at expected value
        /// </summary>
        public const string GreaterThanOrEqual = ">=";

        /// <summary>
        /// Provides search operation for greater than or equality at expected value
        /// </summary>
        public const string LessThanOrEqual = "<=";

        /// <summary>
        /// Provides search operation for expected value contains in given parameter
        /// </summary>
        public const string Contains = "/=";

        /// <summary>
        /// Provides search operation for given parameter starts with expected value
        /// </summary>
        public const string StartsWith = "_";

        /// <summary>
        /// Provides search operation for expected value does not contains in given parameter
        /// </summary>
        public const string NotContains = "!/=";

        /// <summary>
        /// Provides search operation for given parameter does not starts with expected value
        /// </summary>
        public const string NotStartsWith = "!_";
    }
}
