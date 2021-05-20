using Newtonsoft.Json;
using System;

namespace WordPressPCL.Models
{
	/// <summary>
	/// Class JWTData.
	/// </summary>
	public class JWTData
    {
		/// <summary>
		/// Gets or sets the token.
		/// </summary>
		/// <value>The token.</value>
		[JsonProperty("token")]
        public string Token { get; set; }

		/// <summary>
		/// Gets or sets the display name.
		/// </summary>
		/// <value>The display name.</value>
		[JsonProperty("displayName")]
        public string DisplayName { get; set; }

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		[JsonProperty("email")]
        public string Email { get; set; }

		/// <summary>
		/// Gets or sets the name of the nice.
		/// </summary>
		/// <value>The name of the nice.</value>
		[JsonProperty("nicename")]
        public string NiceName { get; set; }
    }
}
