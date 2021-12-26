namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Person"> на таблицу и наоборот.
    /// </summary>.
    internal class PersonMap : ClassMap<Person>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PersonMap"/>.
        /// </summary>
        public PersonMap()
        {
            this.Table("Persons");
            this.Id(x => x.Id);

            this.Map(x => x.FirstName).Length(255);
            this.Map(x => x.LastName).Length(255);
            this.Map(x => x.MiddleName).Length(255);
            this.Map(x => x.TelNum).Length(11);

        }
    }
}
