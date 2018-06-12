using Newtonsoft.Json;

namespace ExemploNotificacao.Models
{
    public class Error
    {
        /// <summary>
        ///     Error code
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        ///     Error message
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Message { get; set; }

        /// <summary>
        ///     Error target
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }
    }
}
