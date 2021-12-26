﻿namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using Dentistry.Core;


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
            this.Table("Appointments");

            this.Id(x => x.IdAppointment);

            this.Map(x => x.AppointmentDate);
            

            this.References(x => x.ServiceName);
            this.References(x => x.Doctor);
            this.References(x => x.Client);

        }
    }
}
