using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosoem.FiscalAPI.Dtos.Common
{
    public class PagedList<T> : IReadOnlyList<T>
    {
        private readonly IList<T> _subSet;

        public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            _subSet = items as IList<T> ?? new List<T>(items);
        }

        public int PageNumber { get; }

        public int TotalPages { get; }

        public bool IsFirstPage => PageNumber == 1;

        public bool IsLastPage => PageNumber == TotalPages;

        public int Count => _subSet.Count;

        public T this[int index] => _subSet[index];

        public IEnumerator<T> GetEnumerator() => _subSet.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _subSet.GetEnumerator();
    }
}