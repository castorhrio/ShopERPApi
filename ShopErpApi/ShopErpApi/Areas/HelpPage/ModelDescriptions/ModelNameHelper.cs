namespace ShopErpApi.Areas.HelpPage.ModelDescriptions
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="ModelNameHelper" />.
    /// </summary>
    internal static class ModelNameHelper
    {
        /// <summary>
        /// The GetModelName.
        /// </summary>
        /// <param name="type">The type<see cref="Type"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetModelName(Type type)
        {
            ModelNameAttribute modelNameAttribute = type.GetCustomAttribute<ModelNameAttribute>();
            if (modelNameAttribute != null && !String.IsNullOrEmpty(modelNameAttribute.Name))
            {
                return modelNameAttribute.Name;
            }

            string modelName = type.Name;
            if (type.IsGenericType)
            {
                // Format the generic type name to something like: GenericOfAgurment1AndArgument2
                Type genericType = type.GetGenericTypeDefinition();
                Type[] genericArguments = type.GetGenericArguments();
                string genericTypeName = genericType.Name;

                // Trim the generic parameter counts from the name
                genericTypeName = genericTypeName.Substring(0, genericTypeName.IndexOf('`'));
                string[] argumentTypeNames = genericArguments.Select(t => GetModelName(t)).ToArray();
                modelName = String.Format(CultureInfo.InvariantCulture, "{0}Of{1}", genericTypeName, String.Join("And", argumentTypeNames));
            }

            return modelName;
        }
    }
}
