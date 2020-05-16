namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Defines the <see cref="ParameterDescription" />.
    /// </summary>
    public class ParameterDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDescription"/> class.
        /// </summary>
        public ParameterDescription()
        {
            Annotations = new Collection<ParameterAnnotation>();
        }

        /// <summary>
        /// Gets the Annotations.
        /// </summary>
        public Collection<ParameterAnnotation> Annotations { get; private set; }

        /// <summary>
        /// Gets or sets the Documentation.
        /// </summary>
        public string Documentation { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the TypeDescription.
        /// </summary>
        public ModelDescription TypeDescription { get; set; }
    }
}
