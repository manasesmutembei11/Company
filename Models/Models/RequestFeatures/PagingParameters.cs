using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.RequestFeatures
{
    public class PagingParameters : RequestParameters
    {
        public string Search { get; set; }= string.Empty;

    }
}
