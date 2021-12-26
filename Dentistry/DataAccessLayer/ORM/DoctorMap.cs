namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Doctor"> на таблицу и наоборот.
    /// </summary>.
    internal class DoctorMap : ClassMap<Doctor>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DoctorMap"/>.
        /// </summary>
        public DoctorMap()
        {
            this.Table("Doctors");
            this.Id(x => x.IdDoctor);

            this.Map(x => x.TelNum).Length(11);
            this.Map(x => x.FirstName).Length(255);
            this.Map(x => x.LastName).Length(255);
            this.Map(x => x.MiddleName).Length(255);

            this.References(x => x.Specializing);
            this.HasMany(x => x.Appointments).Not.Inverse().Cascade.Delete();
        }
    }
}
