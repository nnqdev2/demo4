using System.Collections.Generic;
using System.Threading.Tasks;
using OlprrApi.Storage.Entities;
using Dto = OlprrApi.Models.Request;

namespace OlprrApi.Storage.Repositories
{
    public interface IOlprrRepository
    {
        Task<IEnumerable<ConfirmationType>> GetConfirmationTypes();
        Task<IEnumerable<County>> GetCounties();
        Task<IEnumerable<DiscoveryType>> GetDiscoveryTypes();
        Task<IEnumerable<QuadrantT>> GetQuadrants();
        Task<IEnumerable<ReleaseCauseType>> GetReleaseCauseTypes();
        Task<IEnumerable<SiteTypeT>> GetSiteTypes();
        Task<IEnumerable<SourceType>> GetSourceTypes();
        Task<IEnumerable<State>> GetStates();
        Task<IEnumerable<StreetTypeT>> GetStreetTypes();
        Task<int> InsertOLPRRIncidentRecord(ApOLPRRInsertIncident apOLPRRInsertIncident);
        //Task<IEnumerable<ApOLPRRGetLustLookup>> GetApOLPRRGetLustLookups(Dto.LustSiteAddressSearch lustSiteAddressSearch);
        Task GetApOLPRRGetLustLookups(Dto.LustSiteAddressSearch lustSiteAddressSearch);
    }
}
