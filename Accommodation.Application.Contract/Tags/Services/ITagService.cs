using Accommodation.Application.Contract.Tags.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Tags.Services
{
    public interface ITagService
    {
        void CreateTag(TagDTO tagDTO);

        List<TagDTO> GetALLTags();

        void UpdateTag(UpdateTagDTO tag);
    }
}