namespace DataAccessLayer.Repository
{
    using System;

    using System.Linq;
    using System.Linq.Expressions;
    using Dentistry.Core;
    using NHibernate;

    public class ServiceNameRepository : IRepository<ServiceName>
    {
        private ISession session;

        public ServiceNameRepository(ISession session)
        {
            this.session = session
            ?? throw new ArgumentNullException(nameof(session));
        }

        public IQueryable<ServiceName> Filter( Expression<Func<ServiceName, bool>> predicate)
        {
            return this.GetAll()
                .Where(predicate);
        }

        public ServiceName Find(Expression<Func<ServiceName, bool>> predicate)
        {
            return this.GetAll()
    .FirstOrDefault(predicate);
        }

        public ServiceName Get(int id) =>
                  session?.Get<ServiceName>(id);

        public IQueryable<ServiceName> GetAll() =>
                  session?.Query<ServiceName>();
        public ServiceName GetByTitle(string title)
        {
            return this.GetAll().FirstOrDefault<ServiceName>(x => x.Title == title);
        }
        public bool Save(ServiceName entity)
        {
            try
            {
                this.session?.Save(entity);
                this.session.Flush();
                return true;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
