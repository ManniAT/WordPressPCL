using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace WordPressPCL.Client {

	/// <summary>
	/// Client class for interaction with Tags endpoint WP REST API
	/// </summary>
	public class Tags : CRUDOperation<Tag, TagsQueryBuilder> {

		#region Init

		private const string _methodPath = "tags";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pHttpHelper">reference to HttpHelper class for interaction with HTTP</param>
		/// <param name="defaultPath">path to site, EX. http://demo.com/wp-json/ </param>
		public Tags(HttpHelper pHttpHelper, string defaultPath) : base(pHttpHelper, defaultPath, _methodPath, true) { }

		#endregion Init
	}
}