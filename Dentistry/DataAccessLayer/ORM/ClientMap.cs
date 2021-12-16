namespace DataAccessLayer.ORM
{
    using Dentistry.Core;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref= "Client"> на таблицу и наоборот.
    /// </summary>.
    internal class ClientMap : ClassMap<Client>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ClientMap"/>.
        /// </summary>
        public ClientMap()
        {
            this.Schema("dbo");
            this.Table("Clients");
            this.Id(x => x.IdClient).GeneratedBy.Guid();

            this.Map(x => x.TelNum).Length(11);
            this.Map(x => x.Location).Length(255);
            this.Map(x => x.MedPolNum).Length(16);
            this.Map(x => x.Passport).Length(10);
            this.Map(x => x.BirthDate);
            this.Map(x => x.FirstName).Length(255);
            this.Map(x => x.LastName).Length(255);
            this.Map(x => x.MiddleName).Length(255);

        }
    }
}
