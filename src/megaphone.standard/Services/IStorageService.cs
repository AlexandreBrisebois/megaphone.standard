using System.Threading.Tasks;

namespace Megaphone.Standard.Services
{
    public interface IStorageService<TContent>
    {
        Task<TContent> GetAsync(string contentKey);
        Task SetAsync(string contentKey, TContent content);
    }
}

