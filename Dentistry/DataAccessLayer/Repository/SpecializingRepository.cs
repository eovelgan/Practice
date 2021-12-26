namespace DataAccessLayer.Repository
{
    using System;

    using System.Linq;
    using System.Linq.Expressions;
    using Dentistry.Core;
    using NHibernate;

    public class SpecializingRepository : IRepository<Specializing>
    {
        private ISession session;

        public SpecializingRepository(ISession session)

        {

            this.session = session

            ?? throw new ArgumentNullException(nameof(session));

        }

        public IQueryable<Specializing> Filter(Expression<Func<Specializing, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        public Specializing Find(Expression<Func<Specializing, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Specializing Get(int id) =>
                  session?.Get<Specializing>(id);

        public IQueryable<Specializing> GetAll() =>
                  session?.Query<Specializing>();

        public bool Save(Specializing entity)
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
        public Specializing GetByTitle(string title)
        {
            return this.GetAll().FirstOrDefault<Specializing>(x => x.Title == title);
        }
        public IQueryable<Specializing> FindSpecStartWith(string str)
        {
            return this.GetAll().Where(x => x.Title.StartsWith(str));
        }
    }
}
