using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace WordPressPCL.Client
{
    /// <summary>
    /// Client class for interaction with Categories endpoint WP REST API
    /// </summary>
    public class Categories : CRUDOperation<Category, CategoriesQueryBuilder>
    {
        #region Init

        private const string _methodPath = "categories";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pHttpHelper">reference to HttpHelper class for interaction with HTTP</param>
        /// <param name="defaultPath">path to site, EX. http://demo.com/wp-json/ </param>
        public Categories(HttpHelper pHttpHelper, string defaultPath) : base(pHttpHelper, defaultPath, _methodPath, true)
        {
        }

        #endregion Init
    }
}