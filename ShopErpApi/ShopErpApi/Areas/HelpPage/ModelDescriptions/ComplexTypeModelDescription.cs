namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Defines the <see cref="ComplexTypeModelDescription" />.
    /// </summary>
    public class ComplexTypeModelDescription : ModelDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexTypeModelDescription"/> class.
        /// </summary>
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        /// <summary>
        /// Gets the Properties.
        /// </summary>
        public Collection<ParameterDescription> Properties { get; private set; }
    }
}
