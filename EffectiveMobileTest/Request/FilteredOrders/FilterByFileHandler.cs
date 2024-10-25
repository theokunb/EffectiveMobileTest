using EffectiveMobileTest.Services;
using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class FilterByFileHandler : IRequestHandler<FilterByFileRequest, Guid>
    {
        private readonly FilterService _filterService;
        private readonly FileParserService _fileParserService;

        public FilterByFileHandler(FilterService filterService, FileParserService fileParserService)
        {
            _filterService = filterService;
            _fileParserService = fileParserService;
        }

        public async Task<Guid> Handle(FilterByFileRequest request, CancellationToken cancellationToken)
        {
            var filteredByParams = await _fileParserService.ParseAsync(request.File, cancellationToken);
            return await _filterService.FilterByParamsAsync(filteredByParams.CityDistrict.Value, filteredByParams.FirstDeliveryDateTime.Value, cancellationToken);
        }
    }
}
