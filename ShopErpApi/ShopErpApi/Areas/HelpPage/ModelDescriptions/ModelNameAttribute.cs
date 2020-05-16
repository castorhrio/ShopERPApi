namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System;

    /// <summary>
    /// Use this attribute to change the name of the <see cref="ModelDescription"/> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNameAttribute"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the Name.
        /// </summary>
        public string Name { get; private set; }
    }
}
