using EffectiveMobileTest.Request.FilteredOrders;
using FluentValidation;
using Newtonsoft.Json;

namespace EffectiveMobileTest.Services
{
    public class FileParserService
    {
        private readonly ILogger<FileParserService> _logger;
        private readonly FilterByParamsValidator _filterByParamsValidator;

        public FileParserService(ILogger<FileParserService> logger, FilterByParamsValidator filterByParamsValidator)
        {
            _logger = logger;
            _filterByParamsValidator = filterByParamsValidator;
        }

        public async Task<FilterByParamsRequest> ParseAsync(IFormFile file, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"PARSING_FILE {file.FileName}");
            using StreamReader sr = new StreamReader(file.OpenReadStream());
            string text = await sr.ReadToEndAsync(cancellationToken);

            var filteredByParams = JsonConvert.DeserializeObject<FilterByParamsRequest>(text)
                ?? throw new Exception("PARSING_FILE_ERROR");

            var validateResult = _filterByParamsValidator.Validate(filteredByParams);

            if (validateResult.IsValid)
            {
                return filteredByParams;
            }

            throw new ValidationException(validateResult.Errors);
        }
    }
}
