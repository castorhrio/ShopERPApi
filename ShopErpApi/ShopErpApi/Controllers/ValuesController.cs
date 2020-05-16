namespace ShopErpApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    /// <summary>
    /// Defines the <see cref="ValuesController" />.
    /// </summary>
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// The Get.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{string}"/>.</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// The Get.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// The Post.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// The Put.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <param name="value">The value<see cref="string"/>.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        public void Delete(int id)
        {
        }
    }
}
