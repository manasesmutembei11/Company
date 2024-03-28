using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Blog
{
    public class Comment
    {
        public Guid CommentId { get; set; }

        public string? CommenterName { get; set; }

        public string? CommenterEmail {get; set; }

        public string?  CommentContent { get; set; }

        public DateTime CommentDate { get; set; }
    }
}