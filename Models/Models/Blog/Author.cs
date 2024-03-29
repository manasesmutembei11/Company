using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Blog
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string?   Bio { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public IEnumerable<Article>? Articles { get; set;}

    }
}