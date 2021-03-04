using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natedpalm.SharedKernel.Interfaces
{
    public interface IPaginatedList<T> : IList<T> where T : BaseEntity, IAggregateRoot
    {
        int PageIndex { get; }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}