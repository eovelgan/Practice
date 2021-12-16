namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Specializing"> на таблицу и наоборот.
    /// </summary>.
    internal class SpecializingMap : ClassMap<Specializing>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SpecializingMap"/>.
        /// </summary>
        public SpecializingMap()
        {
            this.Schema("dbo");

            this.Table("Specializings");

            this.Id(x => x.IdSpecializing).GeneratedBy.Guid();

            this.Map(x => x.Title).Length(255);

        }
    }
}
