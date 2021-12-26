namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Service"> на таблицу и наоборот.
    /// </summary>.
    internal class ServiceMap : ClassMap<ServiceName>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ServiceMap"/>.
        /// </summary>
        public ServiceMap()
        {

            this.Table("[ServicesName]");

            this.Id(x => x.IdService);

            this.Map(x => x.Price);
            this.Map(x => x.Title).Length(255);

            this.HasMany(x => x.Appointments).Not.Inverse().Cascade.Delete();
        }
    }
}
