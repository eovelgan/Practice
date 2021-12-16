namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Service"> на таблицу и наоборот.
    /// </summary>.
    internal class ServiceMap : ClassMap<Service>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ServiceMap"/>.
        /// </summary>
        public ServiceMap()
        {
            this.Schema("dbo");

            this.Table("Services");

            this.Id(x => x.IdService).GeneratedBy.Guid();

            this.Map(x => x.Price);
            this.Map(x => x.Title).Length(255);

        }
    }
}
