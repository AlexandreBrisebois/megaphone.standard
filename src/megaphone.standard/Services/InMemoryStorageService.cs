using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Megaphone.Standard.Services
{
    public class InMemoryStorageService<TContent> : IStorageService<TContent>
    {
        private readonly ConcurrentDictionary<string, TContent> storage = new();

        public Task<TContent> GetAsync(string contentKey)
        {
            if (storage.TryGetValue(contentKey, out var value))
            {
                return Task.FromResult(value);
            }

            throw new KeyNotFoundException(contentKey);
        }

        public Task SetAsync(string contentKey, TContent content)
        {
            storage.AddOrUpdate(contentKey, content, (s, c) => content);

            return Task.CompletedTask;
        }
    }
}

