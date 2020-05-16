namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Defines the <see cref="EnumTypeModelDescription" />.
    /// </summary>
    public class EnumTypeModelDescription : ModelDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTypeModelDescription"/> class.
        /// </summary>
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        /// <summary>
        /// Gets the Values.
        /// </summary>
        public Collection<EnumValueDescription> Values { get; private set; }
    }
}
