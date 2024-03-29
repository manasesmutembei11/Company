using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Exceptions
{
    public sealed class AuthorNotFoundException : NotFoundException
    {
        public AuthorNotFoundException(Guid AuthorId) :
            base($"The author with id: {AuthorId} doesn't exist in the database.")
        {
        }
    }
}
