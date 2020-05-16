namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System;

    /// <summary>
    /// Defines the <see cref="ParameterAnnotation" />.
    /// </summary>
    public class ParameterAnnotation
    {
        /// <summary>
        /// Gets or sets the AnnotationAttribute.
        /// </summary>
        public Attribute AnnotationAttribute { get; set; }

        /// <summary>
        /// Gets or sets the Documentation.
        /// </summary>
        public string Documentation { get; set; }
    }
}
