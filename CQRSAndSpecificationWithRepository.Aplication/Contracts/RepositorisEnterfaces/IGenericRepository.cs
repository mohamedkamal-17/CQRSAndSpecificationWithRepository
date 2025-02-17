using CQRSAndSpecificationWithRepository.Aplication.specefication;

namespace CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces
{
    public interface IGenericRepository<T> where T : class
    {

        IQueryable<T> ApllaySpeceification<T>(IQueryable<T> _dbSet, Specification<T> specfication) where T : class;
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
