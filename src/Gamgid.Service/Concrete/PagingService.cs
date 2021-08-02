using Gamgid.Models;
using Gamgid.Paging.Const;
using Gamgid.Service.Abstract;

using System;
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
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (gamgidModel == null)
            {
                throw new ArgumentNullException(nameof(gamgidModel));
            }

            IQueryable<T> result = Paging(data, gamgidModel);

            result = Filter(result, gamgidModel);

            return result;
        }

        private static IQueryable<T> Paging<T>(IQueryable<T> data, GamgidModel gamgidModel) where T : class
        {
            return data.Skip(gamgidModel.PageSize * gamgidModel.PageNumber).Take(gamgidModel.PageSize);
        }

        private static IQueryable<T> Filter<T>(IQueryable<T> result, GamgidModel gamgidModel) where T : class
        {
            switch (gamgidModel.SearchCondition)
            {
                case PagingConsts.Contains:
                    return result.Where(c => gamgidModel.SearchValue.Contains(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.Equals:
                    return result.Where(c => gamgidModel.SearchValue == c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString()).AsQueryable();
                case PagingConsts.GreaterThan:
                    CheckIsNumber(gamgidModel.SearchValue);

                    return result.Where(c => int.Parse(gamgidModel.SearchValue) > int.Parse(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.GreaterThanOrEqual:
                    CheckIsNumber(gamgidModel.SearchValue);

                    return result.Where(c => int.Parse(gamgidModel.SearchValue) >= int.Parse(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.LessThan:
                    CheckIsNumber(gamgidModel.SearchValue);

                    return result.Where(c => int.Parse(gamgidModel.SearchValue) < int.Parse(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.LessThanOrEqual:
                    CheckIsNumber(gamgidModel.SearchValue);

                    return result.Where(c => int.Parse(gamgidModel.SearchValue) <= int.Parse(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.NotContains:
                    return result.Where(c => !gamgidModel.SearchValue.Contains(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.NotEquals:
                    return result.Where(c => gamgidModel.SearchValue != c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString()).AsQueryable();
                case PagingConsts.NotStartsWith:
                    return result.Where(c => !gamgidModel.SearchValue.StartsWith(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                case PagingConsts.StartsWith:
                    return result.Where(c => gamgidModel.SearchValue.StartsWith(c.GetType().GetProperty(gamgidModel.SearchKey).GetValue(c).ToString())).AsQueryable();
                default:
                    return result;
            }
        }

        #region Helper Methods

        private static void CheckIsNumber(string value)
        {
            var checkIsGraterNumeric = int.TryParse(value, out int expectedNumber);

            if (!checkIsGraterNumeric)
            {
                throw new InvalidOperationException($"Parameter value could be numeric value. Value is {value}");
            }
        }

        #endregion
    }
}
