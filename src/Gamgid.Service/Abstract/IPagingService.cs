using Gamgid.Models;

using System.Linq;

namespace Gamgid.Service.Abstract
{
    public interface IPagingService
    {
        IQueryable<T> PageFilter<T>(IQueryable<T> data, GamgidModel gamgidModel) where T : class;
    }
}
