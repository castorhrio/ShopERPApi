namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Defines the <see cref="KeyValuePairModelDescription" />.
    /// </summary>
    public class KeyValuePairModelDescription : ModelDescription
    {
        /// <summary>
        /// Gets or sets the KeyModelDescription.
        /// </summary>
        public ModelDescription KeyModelDescription { get; set; }

        /// <summary>
        /// Gets or sets the ValueModelDescription.
        /// </summary>
        public ModelDescription ValueModelDescription { get; set; }
    }
}
