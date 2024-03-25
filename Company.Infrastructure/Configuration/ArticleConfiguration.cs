using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Models.Blog;

namespace Company.Infrastructure.Configuration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData
            (
            new Article
            {
                ArticleId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                AuthorId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                ArticleImageUrl = "583 Wall Dr. Gwynn Oak, MD 21207",
                Title = "Recipe 1",
                Content = "",
                PublicationDate = DateTime.Now,
                

            },
            new Article
            {
                ArticleId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                AuthorId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                ArticleImageUrl = "583 Wall Dr. Gwynn Oak, MD 21207",
                Title = "Recipe 2",
                Content = "",
                PublicationDate = DateTime.Now,
            }
            );
        }
    }

}
