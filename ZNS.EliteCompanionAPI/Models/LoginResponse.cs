using System.Net;

namespace ZNS.EliteCompanionAPI.Models
{
    /// <summary>
    /// Login response
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// Status of login
        /// </summary>
        public LoginStatus Status { get; set; }
        /// <summary>
        /// Returned http status code for request
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
