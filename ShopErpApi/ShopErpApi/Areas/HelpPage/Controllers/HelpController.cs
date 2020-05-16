namespace ShopErpApi.Areas.HelpPage.Controllers
{
    using ShopErpApi.Areas.HelpPage.ModelDescriptions;
    using ShopErpApi.Areas.HelpPage.Models;
    using System;
    using System.Web.Http;
    using System.Web.Mvc;

    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        /// <summary>
        /// Defines the ErrorViewName.
        /// </summary>
        private const string ErrorViewName = "Error";

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpController"/> class.
        /// </summary>
        public HelpController()
            : this(GlobalConfiguration.Configuration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpController"/> class.
        /// </summary>
        /// <param name="config">The config<see cref="HttpConfiguration"/>.</param>
        public HelpController(HttpConfiguration config)
        {
            Configuration = config;
        }

        /// <summary>
        /// Gets the Configuration.
        /// </summary>
        public HttpConfiguration Configuration { get; private set; }

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult Index()
        {
            ViewBag.DocumentationProvider = Configuration.Services.GetDocumentationProvider();
            return View(Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        /// <summary>
        /// The Api.
        /// </summary>
        /// <param name="apiId">The apiId<see cref="string"/>.</param>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult Api(string apiId)
        {
            if (!String.IsNullOrEmpty(apiId))
            {
                HelpPageApiModel apiModel = Configuration.GetHelpPageApiModel(apiId);
                if (apiModel != null)
                {
                    return View(apiModel);
                }
            }

            return View(ErrorViewName);
        }

        /// <summary>
        /// The ResourceModel.
        /// </summary>
        /// <param name="modelName">The modelName<see cref="string"/>.</param>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult ResourceModel(string modelName)
        {
            if (!String.IsNullOrEmpty(modelName))
            {
                ModelDescriptionGenerator modelDescriptionGenerator = Configuration.GetModelDescriptionGenerator();
                ModelDescription modelDescription;
                if (modelDescriptionGenerator.GeneratedModels.TryGetValue(modelName, out modelDescription))
                {
                    return View(modelDescription);
                }
            }

            return View(ErrorViewName);
        }
    }
}
