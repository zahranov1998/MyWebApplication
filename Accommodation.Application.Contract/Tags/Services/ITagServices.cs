using Accommodation.Application.Contract.Tags.DTO;

namespace Accommodation.Application.Contract.Tags.Services
{
    public interface ITagServices
    {
        void CreateTag(TagDTO tagDTO);
    }
}