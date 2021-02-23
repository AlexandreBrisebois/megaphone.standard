using System.Net.Http;
using System.Text.Json.Serialization;

namespace Megaphone.Standard.Representations.Links
{
    public class Link
    {
        [JsonPropertyName("rel")]
        public string Rel { get; private set; }
        [JsonPropertyName("href")]
        public string Href { get; private set; }
        [JsonPropertyName("method")]
        public string Method { get; private set; }

        public Link(string relation, string href, string method)
        {
            Rel = relation;
            Href = href;
            Method = method;
        }

        public static Link Make(string relation, string href, HttpMethod method)
        {
            return new Link(relation, href, method.ToString());
        }
        public static Link Make(string relation, string href)
        {
            return new Link(relation, href, HttpMethod.Get.ToString());
        }
    }
}