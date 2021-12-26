namespace DataAccessLayer.Repository
{
    using System;

    using System.Linq;
    using System.Linq.Expressions;
    using Dentistry.Core;
    using NHibernate;

    public class ClientRepository : IRepository<Client>
    {
        private ISession session;

        public ClientRepository(ISession session)
        {
            this.session = session
            ?? throw new ArgumentNullException(nameof(session));
        }
        public IQueryable<Client> Filter(Expression<Func<Client, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        public Client Find(Expression<Func<Client, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Client Get( int id) =>
                  session?.Get<Client>(id);

        public IQueryable<Client> GetAll() =>
                  session?.Query<Client>();

        public Client GetByLastname(string surname)
        {
            return this.GetAll().FirstOrDefault<Client>(x => x.LastName == surname);
        }
        public bool Save(Client entity)
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
