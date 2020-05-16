namespace ShopErpApi.Areas.HelpPage
{
    using System.Web.Http;
    using System.Web.Mvc;

    /// <summary>
    /// Defines the <see cref="HelpPageAreaRegistration" />.
    /// </summary>
    public class HelpPageAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Gets the AreaName.
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "HelpPage";
            }
        }

        /// <summary>
        /// The RegisterArea.
        /// </summary>
        /// <param name="context">The context<see cref="AreaRegistrationContext"/>.</param>
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HelpPage_Default",
                "Help/{action}/{apiId}",
                new { controller = "Help", action = "Index", apiId = UrlParameter.Optional });

            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}
