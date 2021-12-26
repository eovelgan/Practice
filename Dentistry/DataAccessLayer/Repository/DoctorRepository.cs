namespace DataAccessLayer.Repository
{
    using System;

    using System.Linq;
    using System.Linq.Expressions;
    using Dentistry.Core;
    using NHibernate;

    public class DoctorRepository : IRepository<Doctor>
    {
        private ISession session;

        public DoctorRepository(ISession session)
        {
            this.session = session
            ?? throw new ArgumentNullException(nameof(session));
        }
        public IQueryable<Doctor> Filter( Expression<Func<Doctor, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        public Doctor Find( Expression<Func<Doctor, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Doctor Get( int id) =>
                  session?.Get<Doctor>(id);

        public IQueryable<Doctor> GetAll() =>
                  session?.Query<Doctor>();

        public Doctor GetByLastname(string surname)
        {
            return this.GetAll().FirstOrDefault<Doctor>(x => x.LastName == surname);
        }

        public bool Save(Doctor entity)
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
