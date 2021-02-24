using Megaphone.Standard.Representations.Links;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace Megaphone.Standard.Representations
{
    public abstract class Representation
    {
        private readonly List<Link> links = new();

        [JsonPropertyName("links")]
        public IEnumerable<Link> Links { get { return links; } }

        public void AddLink(string relation, string href)
        {
            links.Add(Link.Make(relation, href));
        }
        public void AddLink(string relation, string href, HttpMethod method)
        {
            links.Add(Link.Make(relation, href, method));
        }
    }
}