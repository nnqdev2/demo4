using System.Threading.Tasks;
using EntityDto = OlprrApi.Storage.Entities;
using OlprrApi.Storage.Repositories;
using AutoMapper;
using OlprrApi.Models.Request;
using OlprrApi.Models.Response;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace OlprrApi.Services
{
    public class OlprrReviewService : IOlprrReviewService
    {

        private ILogger<OlprrReviewService> _logger;
        private IOlprrRpository _lustRepository;
        private readonly IMapper _mapper;
        public OlprrReviewService(ILogger<OlprrReviewService> logger, IOlprrRpository lustRepository, IMapper mapper)
        {
            _logger = logger;
            _lustRepository = lustRepository;
            _mapper = mapper;
        }


        public async Task SearchLust(LustSiteAddressSearch lustSiteAddressSearch)
        {
            //var incident = _mapper.Map<ApOLPRRInsertIncident, EntityDto.ApOLPRRInsertIncident>(apOLPRRInsertIncident);
            await _lustRepository.GetApOLPRRGetLustLookups(lustSiteAddressSearch);
        }

        public async Task<IEnumerable<EntityDto.ApOLPRRGetLustLookup>> GetLustSearch(LustSiteAddressSearch lustSiteAddressSearch)
        {
            return await _lustRepository.GetLustSearch(lustSiteAddressSearch);
        }
    }
}
