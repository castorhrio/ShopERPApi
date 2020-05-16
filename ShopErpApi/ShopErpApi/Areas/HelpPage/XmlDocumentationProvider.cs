namespace ShopErpApi.Areas.HelpPage
{
    using ShopErpApi.Areas.HelpPage.ModelDescriptions;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Web.Http.Controllers;
    using System.Web.Http.Description;
    using System.Xml.XPath;

    /// <summary>
    /// A custom <see cref="IDocumentationProvider"/> that reads the API documentation from an XML documentation file.
    /// </summary>
    public class XmlDocumentationProvider : IDocumentationProvider, IModelDocumentationProvider
    {
        /// <summary>
        /// Defines the _documentNavigator.
        /// </summary>
        private XPathNavigator _documentNavigator;

        /// <summary>
        /// Defines the TypeExpression.
        /// </summary>
        private const string TypeExpression = "/doc/members/member[@name='T:{0}']";

        /// <summary>
        /// Defines the MethodExpression.
        /// </summary>
        private const string MethodExpression = "/doc/members/member[@name='M:{0}']";

        /// <summary>
        /// Defines the PropertyExpression.
        /// </summary>
        private const string PropertyExpression = "/doc/members/member[@name='P:{0}']";

        /// <summary>
        /// Defines the FieldExpression.
        /// </summary>
        private const string FieldExpression = "/doc/members/member[@name='F:{0}']";

        /// <summary>
        /// Defines the ParameterExpression.
        /// </summary>
        private const string ParameterExpression = "param[@name='{0}']";

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlDocumentationProvider"/> class.
        /// </summary>
        /// <param name="documentPath">The physical path to XML document.</param>
        public XmlDocumentationProvider(string documentPath)
        {
            if (documentPath == null)
            {
                throw new ArgumentNullException("documentPath");
            }
            XPathDocument xpath = new XPathDocument(documentPath);
            _documentNavigator = xpath.CreateNavigator();
        }

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="controllerDescriptor">The controllerDescriptor<see cref="HttpControllerDescriptor"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetDocumentation(HttpControllerDescriptor controllerDescriptor)
        {
            XPathNavigator typeNode = GetTypeNode(controllerDescriptor.ControllerType);
            return GetTagValue(typeNode, "summary");
        }

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="actionDescriptor">The actionDescriptor<see cref="HttpActionDescriptor"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public virtual string GetDocumentation(HttpActionDescriptor actionDescriptor)
        {
            XPathNavigator methodNode = GetMethodNode(actionDescriptor);
            return GetTagValue(methodNode, "summary");
        }

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="parameterDescriptor">The parameterDescriptor<see cref="HttpParameterDescriptor"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public virtual string GetDocumentation(HttpParameterDescriptor parameterDescriptor)
        {
            ReflectedHttpParameterDescriptor reflectedParameterDescriptor = parameterDescriptor as ReflectedHttpParameterDescriptor;
            if (reflectedParameterDescriptor != null)
            {
                XPathNavigator methodNode = GetMethodNode(reflectedParameterDescriptor.ActionDescriptor);
                if (methodNode != null)
                {
                    string parameterName = reflectedParameterDescriptor.ParameterInfo.Name;
                    XPathNavigator parameterNode = methodNode.SelectSingleNode(String.Format(CultureInfo.InvariantCulture, ParameterExpression, parameterName));
                    if (parameterNode != null)
                    {
                        return parameterNode.Value.Trim();
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// The GetResponseDocumentation.
        /// </summary>
        /// <param name="actionDescriptor">The actionDescriptor<see cref="HttpActionDescriptor"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetResponseDocumentation(HttpActionDescriptor actionDescriptor)
        {
            XPathNavigator methodNode = GetMethodNode(actionDescriptor);
            return GetTagValue(methodNode, "returns");
        }

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="member">The member<see cref="MemberInfo"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetDocumentation(MemberInfo member)
        {
            string memberName = String.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetTypeName(member.DeclaringType), member.Name);
            string expression = member.MemberType == MemberTypes.Field ? FieldExpression : PropertyExpression;
            string selectExpression = String.Format(CultureInfo.InvariantCulture, expression, memberName);
            XPathNavigator propertyNode = _documentNavigator.SelectSingleNode(selectExpression);
            return GetTagValue(propertyNode, "summary");
        }

        /// <summary>
        /// The GetDocumentation.
        /// </summary>
        /// <param name="type">The type<see cref="Type"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetDocumentation(Type type)
        {
            XPathNavigator typeNode = GetTypeNode(type);
            return GetTagValue(typeNode, "summary");
        }

        /// <summary>
        /// The GetMethodNode.
        /// </summary>
        /// <param name="actionDescriptor">The actionDescriptor<see cref="HttpActionDescriptor"/>.</param>
        /// <returns>The <see cref="XPathNavigator"/>.</returns>
        private XPathNavigator GetMethodNode(HttpActionDescriptor actionDescriptor)
        {
            ReflectedHttpActionDescriptor reflectedActionDescriptor = actionDescriptor as ReflectedHttpActionDescriptor;
            if (reflectedActionDescriptor != null)
            {
                string selectExpression = String.Format(CultureInfo.InvariantCulture, MethodExpression, GetMemberName(reflectedActionDescriptor.MethodInfo));
                return _documentNavigator.SelectSingleNode(selectExpression);
            }

            return null;
        }

        /// <summary>
        /// The GetMemberName.
        /// </summary>
        /// <param name="method">The method<see cref="MethodInfo"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string GetMemberName(MethodInfo method)
        {
            string name = String.Format(CultureInfo.InvariantCulture, "{0}.{1}", GetTypeName(method.DeclaringType), method.Name);
            ParameterInfo[] parameters = method.GetParameters();
            if (parameters.Length != 0)
            {
                string[] parameterTypeNames = parameters.Select(param => GetTypeName(param.ParameterType)).ToArray();
                name += String.Format(CultureInfo.InvariantCulture, "({0})", String.Join(",", parameterTypeNames));
            }

            return name;
        }

        /// <summary>
        /// The GetTagValue.
        /// </summary>
        /// <param name="parentNode">The parentNode<see cref="XPathNavigator"/>.</param>
        /// <param name="tagName">The tagName<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string GetTagValue(XPathNavigator parentNode, string tagName)
        {
            if (parentNode != null)
            {
                XPathNavigator node = parentNode.SelectSingleNode(tagName);
                if (node != null)
                {
                    return node.Value.Trim();
                }
            }

            return null;
        }

        /// <summary>
        /// The GetTypeNode.
        /// </summary>
        /// <param name="type">The type<see cref="Type"/>.</param>
        /// <returns>The <see cref="XPathNavigator"/>.</returns>
        private XPathNavigator GetTypeNode(Type type)
        {
            string controllerTypeName = GetTypeName(type);
            string selectExpression = String.Format(CultureInfo.InvariantCulture, TypeExpression, controllerTypeName);
            return _documentNavigator.SelectSingleNode(selectExpression);
        }

        /// <summary>
        /// The GetTypeName.
        /// </summary>
        /// <param name="type">The type<see cref="Type"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string GetTypeName(Type type)
        {
            string name = type.FullName;
            if (type.IsGenericType)
            {
                // Format the generic type name to something like: Generic{System.Int32,System.String}
                Type genericType = type.GetGenericTypeDefinition();
                Type[] genericArguments = type.GetGenericArguments();
                string genericTypeName = genericType.FullName;

                // Trim the generic parameter counts from the name
                genericTypeName = genericTypeName.Substring(0, genericTypeName.IndexOf('`'));
                string[] argumentTypeNames = genericArguments.Select(t => GetTypeName(t)).ToArray();
                name = String.Format(CultureInfo.InvariantCulture, "{0}{{{1}}}", genericTypeName, String.Join(",", argumentTypeNames));
            }
            if (type.IsNested)
            {
                // Changing the nested type name from OuterType+InnerType to OuterType.InnerType to match the XML documentation syntax.
                name = name.Replace("+", ".");
            }

            return name;
        }
    }
}
