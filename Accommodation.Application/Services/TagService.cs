﻿using Accommodation.Application.Contract.Tags.DTO;
using Accommodation.Application.Contract.Tags.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;

namespace Accommodation.Application.Services
{
    public class TagService : ITagService
    {
        public readonly ITagRepository TagRepository;

        public TagService()
        {
            var context = new AccommodationDbContext();

            TagRepository = new TagRepository(context);
        }

        public void CreateTag(TagDTO tagDTO)
        {
            var tag = new Tag(tagDTO.Title);

            TagRepository.Create(tag);
        }

        public void DeleteTag(int id)
        {
            var tag = TagRepository.GetById(id);

            TagRepository.Delete(tag);
        }

        public List<TagDTO> GetALLTags()
        {
            var tags = TagRepository.GetAll();

            return TagMapper.MapToDTOs(tags);
        }

        public void UpdateTag(UpdateTagDTO tag)
        {
            var selectedTag = TagRepository.GetById(tag.Id);

            selectedTag.Update(tag.Title);

            TagRepository.Update();
        }
    }
}