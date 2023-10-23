﻿using System.Web.Http;
using Accommodation.Application.Contract.Tags.DTO;
using Accommodation.Application.Contract.Tags.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
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