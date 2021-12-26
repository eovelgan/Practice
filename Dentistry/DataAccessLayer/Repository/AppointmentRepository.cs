namespace DataAccessLayer.Repository
{
    using System;

    using System.Linq;
    using System.Linq.Expressions;
    using Dentistry.Core;
    using NHibernate;

    public class AppointmentRepository : IRepository<Appointment>
    {
        private ISession session;

        public AppointmentRepository(ISession session)
        {
            this.session = session
            ?? throw new ArgumentNullException(nameof(session));
        }

        public IQueryable<Appointment> Filter(Expression<Func<Appointment, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        public Appointment Find(Expression<Func<Appointment, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Appointment Get( int id) =>
                  session?.Get<Appointment>(id);

        public IQueryable<Appointment> GetAll() =>
                  session?.Query<Appointment>();

        public bool Save(Appointment entity)
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
