using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MemoTime.Core.Domain;

namespace MemoTime.Core.Repositories
{
    public interface ILabelRepository
    {
        Task<Label> GetAsync(Guid id, Guid userId);
        Task<IEnumerable<Label>> BrowseAsync(Guid userId);
        Task AddAsync(Label label);
    }
}