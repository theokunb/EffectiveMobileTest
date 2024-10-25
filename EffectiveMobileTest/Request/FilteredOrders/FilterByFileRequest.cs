using MediatR;

namespace EffectiveMobileTest.Request.FilteredOrders
{
    public class FilterByFileRequest : IRequest<Guid>
    {
        public IFormFile File { get; set; }

        public FilterByFileRequest()
        {
        }

        public FilterByFileRequest(IFormFile file)
        {
            File = file;
        }
    }
}
