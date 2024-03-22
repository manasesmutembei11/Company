using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Blog
{
    public class Category
    {
        public Guid BlogCategoryId { get; set; }

        public int CategoryCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Article>? Article { get; set; }

    }
}