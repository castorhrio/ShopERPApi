namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System;

    /// <summary>
    /// Describes a type model.
    /// </summary>
    public abstract class ModelDescription
    {
        /// <summary>
        /// Gets or sets the Documentation.
        /// </summary>
        public string Documentation { get; set; }

        /// <summary>
        /// Gets or sets the ModelType.
        /// </summary>
        public Type ModelType { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }
    }
}
