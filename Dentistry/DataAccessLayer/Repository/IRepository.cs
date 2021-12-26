namespace DataAccessLayer.Repository
{
    using NHibernate;
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Интерфейс для репозитория.
    /// </summary>
    /// <typeparam name="TEntity"> Сущность. </typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Показать сущность.
        /// </summary>
        /// <param name="id"> Идентификатор. </param>
        /// <returns> Сущность по идентификатору. </returns>
        TEntity Get(int id);

        /// <summary>
        /// Поиск по предикату.
        /// </summary>
        /// <param name="predicate"> Условие. </param>
        /// <returns>Найденную сущность. </returns>
        TEntity Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Показать все записи.
        /// </summary>
        /// <returns> Содержимое таблицы. </returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Выдает последовательность (лениво) по заданному условию.
        /// </summary>
        /// <param name="predicate"> Условие. </param>
        /// <returns> Последовательность. </returns>
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

    }
}