using Accommodation.Application.Contract.Tags.DTO;

namespace Accommodation.Application.Contract.Tags.Services
{
    public interface ITagService
    {
        void CreateTag(TagDTO tagDTO);
    }
}