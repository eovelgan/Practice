namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Appointment"> на таблицу и наоборот.
    /// </summary>.
    internal class AppointmentMap : ClassMap<Appointment>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AppointmentMap"/>.
        /// </summary>
        public AppointmentMap()
        {
            this.Schema("dbo");

            this.Table("Appointments");

            this.Id(x => x.IdAppointment);

            this.Map(x => x.AppointmentDate);
            this.Map(x => x.Service);
            this.Map(x => x.Doctor);
            this.Map(x => x.Client);

            this.References(x => x.Service)
                .Cascade.Delete();
            this.References(x => x.Doctor)
                .Cascade.Delete();
            this.References(x => x.Client)
                .Cascade.Delete();

        }
    }
}
