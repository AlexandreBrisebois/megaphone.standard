using Megaphone.Standard.Representations.Links;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace Megaphone.Standard.Representations
{
    public abstract class Representation
    {
        [JsonPropertyName("links")]
        public List<Link> Links { get; init; } = new();

        public void AddLink(string relation, string href)
        {
            Links.Add(Link.Make(relation, href));
        }
        public void AddLink(string relation, string href, HttpMethod method)
        {
            Links.Add(Link.Make(relation, href, method));
        }
    }
}