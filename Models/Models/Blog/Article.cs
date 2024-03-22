using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Company.Core.Models.Blog
{
    public class Article
    {
        public Guid ArticleId { get; set; }

        public Guid AuthorId { get; set; }  
        public string? Title { get; set; }
        public string? Content { get; set; }

        public DateTime PublicationDate { get; set; }

        public Author? Author { get; set; }

        public Category? Category { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
