using CQRSAndSpecificationWithRepository.Aplication.Contracts.RepositorisEnterfaces;
using CQRSAndSpecificationWithRepository.Aplication.specefication;
using CQRSAndSpecificationWithRepository.Infrastructure.DataHelper;
using CQRSAndSpecificationWithRepository.Infrastructure.specefication;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndSpecificationWithRepository.Infrastructure.Repositoris
{
    public class GenericRepository<T>(ApplicationContext context) : IGenericRepository<T> where T : class
    {

        DbSet<T> _dbSet = context.Set<T>();



        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> ApllaySpeceification<T>(IQueryable<T> _dbSet, Specification<T> specfication) where T : class
        {
            return SpecificationEvaluater.GetQuerable(_dbSet, specfication);
        }
    }
}
