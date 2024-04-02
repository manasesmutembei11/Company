using AutoMapper;
using Company.Core.DTOs;
using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDto>();

            CreateMap<Author, AuthorDto>();

            CreateMap<ArticleForCreationDto, Article>();

            CreateMap<AuthorForCreationDto, Author>();

            CreateMap<AuthorForUpdateDto, Author>();    
        }
    }

}
