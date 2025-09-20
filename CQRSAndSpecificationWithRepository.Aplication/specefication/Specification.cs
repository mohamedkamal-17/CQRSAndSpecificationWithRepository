using System.Linq.Expressions;

namespace CQRSAndSpecificationWithRepository.Aplication.specefication
{
    public abstract class Specification<T> where T : class
    {
        public Specification() { }
        public Specification(Expression<Func<T, bool>> criatria)
        {
            Criatria = criatria;
        }
        public Expression<Func<T, bool>>? Criatria { get; }
        public bool IsSpiltQuery { get; private set; }
        public List<Expression<Func<T, object>>>? IncludesExpression { get; private set; } = new();

        public Expression<Func<T, object>>? OrderByExpression { get; private set; }
        public Expression<Func<T, object>>? OrderByDescendingExpression { get; private set; }
        public List<Expression<Func<T, object>>>? IgnoreNavigations { get; private set; } = new();
        protected void AddIncluds(Expression<Func<T, object>> IncudeExpression) =>
            IncludesExpression.Add(IncudeExpression);

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression) =>
            OrderByExpression = orderByExpression;


        protected void AddOrderByDec(Expression<Func<T, object>> orderByDesExpression) =>
            OrderByDescendingExpression = OrderByDescendingExpression;


        public void SpiltQuery(bool split) =>
         IsSpiltQuery = split;


    }
}
