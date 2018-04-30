using OlprrApi.Models.Request;
using OlprrApi.Storage.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace OlprrApi.Services
{
    public interface IOlprrReviewService
    {
        Task SearchLust (LustSiteAddressSearch lustSiteAddressSearch);
        Task<IEnumerable<ApOLPRRGetLustLookup>> GetLustSearch(LustSiteAddressSearch lustSiteAddressSearch);

    }
}
