using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Models.Blog;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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
                ArticleId = new Guid("81abbca8-664d-4b20-b5de-024705497d4a"),
                ArticleImageUrl = "583 Wall Dr. Gwynn Oak, MD 21207",
                Title = "Recipe 1",
                Content = "",
                PublicationDate = DateTime.Now,
            },
            new Article
            {
                ArticleId = new Guid("83abbca8-664d-4b20-b5de-024705497d4a"),
                ArticleImageUrl = "583 Wall Dr. Gwynn Oak, MD 21207",
                Title = "Recipe 2",
                Content = "",
                PublicationDate = DateTime.Now,
            }
            );
        }
    }

}
