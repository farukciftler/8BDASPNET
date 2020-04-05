using System;
using System.Collections.Generic;
using System.Linq;

namespace _8BD.Helpers
{
    public static class Pagination
    {
        public static PagedData<T> PagedResult<T>(this IOrderedEnumerable<T> list, int PageNumber, int PageSize) where T : class
        {
            var result = new PagedData<T>();
            result.Data = list.Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
            result.TotalPages = Convert.ToInt32(Math.Ceiling((double)list.Count() / PageSize));
            result.CurrentPage = PageNumber;
            return result;
        }
    }
}