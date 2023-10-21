using Accommodation.Application.Contract.Tags.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class TagMapper
    {
        public static TagDTO MapToDTO(Tag tag)
        {
            return new TagDTO()
            {
                hotels = HotelMapper.MapToDTOs(tag.Hotels),
                Title = tag.Title
            };
        }

        public static List<TagDTO> MapToDTOs(List<Tag> tags)
        {
            return tags.Select(t => MapToDTO(t)).ToList();
        }

        public static Tag MapToModel(TagDTO tagDTO)
        {
            return new Tag(tagDTO.Title);
        }

        public static List<Tag> MapToModelList(List<TagDTO> tagDTOs) 
        {
            return tagDTOs.Select(t=> MapToModel(t)).ToList();
        }
    }
}