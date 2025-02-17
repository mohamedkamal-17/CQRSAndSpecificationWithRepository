using CQRSAndSpecificationWithRepository.Aplication.specefication;
using Microsoft.EntityFrameworkCore;
namespace CQRSAndSpecificationWithRepository.Infrastructure.specefication
{
    public static class SpecificationEvaluater
    {
        public static IQueryable<TEntity> GetQuerable<TEntity>(IQueryable<TEntity> inputQyery,
            Specification<TEntity> specification) where TEntity : class
        {
            IQueryable<TEntity> query = inputQyery;




            if (specification.IncludesExpression.Any())
                foreach (var item in specification.IncludesExpression)
                    query = query.Include(item);

            if (specification.OrderByExpression is not null)
                query = query.OrderBy(specification.OrderByExpression);

            if (specification.OrderByDescendingExpression is not null)
                query = query.OrderByDescending(specification.OrderByDescendingExpression);

            if (specification.IsSpiltQuery)
                query = query.AsSplitQuery();

            return query;

        }
    }
}
