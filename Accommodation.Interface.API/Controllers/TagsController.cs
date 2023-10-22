using Accommodation.Application.Contract.Tags.DTO;
using Accommodation.Application.Contract.Tags.Services;
using Accommodation.Application.Services;
using System.Web.Http;

namespace Accommodation.Interface.API.Controllers
{
    public class TagsController:ApiController
    {
        public readonly ITagService tagService;

        public TagsController()
        {
            tagService = new TagService();
        }

        [HttpPost]
        public void Post(TagDTO tagDTO)
        {
            tagService.CreateTag(tagDTO);
        }
    }
}