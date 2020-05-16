namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="IModelDocumentationProvider" />.
    /// </summary>
    public interface IModelDocumentationProvider
    {
        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="member">The member<see cref="MemberInfo"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GetDocumentation(MemberInfo member);

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="type">The type<see cref="Type"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GetDocumentation(Type type);
    }
}
