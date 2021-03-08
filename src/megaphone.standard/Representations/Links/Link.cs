using System.Net.Http;
using System.Text.Json.Serialization;

namespace Megaphone.Standard.Representations.Links
{
    public class Link
    {
        [JsonPropertyName("rel")]
        public string Rel { get; init; }
        [JsonPropertyName("href")]
        public string Href { get; init; }
        [JsonPropertyName("method")]
        public string Method { get; init; }

        public Link()
        {

        }

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