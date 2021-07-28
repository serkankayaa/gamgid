using Gamgid.Models;
using Gamgid.Paging.Const;
using Gamgid.Service.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gamgid.Service.Concrete
{
    public class PagingService : IPagingService
    {
        public PagingService()
        {

        }

        public IQueryable<T> PageFilter<T>(IQueryable<T> data, GamgidModel gamgidModel) where T : class
        {
            if(data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if(gamgidModel == null)
            {
                throw new ArgumentNullException(nameof(gamgidModel));
            }

            IQueryable<T> result;

            result = data.Skip(gamgidModel.PageSize * gamgidModel.PageNumber).Take(gamgidModel.PageSize);

            if(gamgidModel.SearchCondition == PagingConsts.Contains)
            {
                result = result.Where(c => gamgidModel.SearchValue.Contains(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
            }
            else if(gamgidModel.SearchCondition == PagingConsts.Equals)
            {
                result = result.Where(c => gamgidModel.SearchValue == c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString()).AsQueryable();
            }

            return result;
        }
    }
}
