using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.RequestFeatures
{
    public class PagedList<T>
    {

        public List<T> Data { get; set; }
        public MetaData MetaData { get; set; }
        public PagedList()
        {

        }
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            Data = new List<T>();
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };

            Data.AddRange(items);
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
        public static Task<PagedList<T>> ToPagedListAsync(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            return Task.Run(() =>
            {
                var count = source.Count();
                var items = source
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize).ToList();

                return new PagedList<T>(items, count, pageNumber, pageSize);
            });

        }
    }
}
