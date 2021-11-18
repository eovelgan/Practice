namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Прием.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Appointment"/>.
        /// </summary>
        /// <param name="idAppointment"> Идентификатор приема.</param>
        /// <param name="year"> Год приема.</param>
        /// <param name="month"> Месяц приема.</param>
        /// <param name="day"> День приема.</param>
        /// <param name="hour"> Час приема.</param>
        /// <param name="minute"> Минута приема.</param>
        /// <param name="idService">Идентификатор услуги.</param>
        /// <param name="idClient"> Идентификатор клиента.</param>
        /// <param name="idDoctor">Идентификатор врача.</param>
        public Appointment(int idAppointment, int year, int month, int day, int hour, int minute, int idService, int idClient, int idDoctor)
        {
            this.IdAppointment = idAppointment;
            this.AppointmentDate = new DateTime(year, month, day, hour, minute, 0);
            this.IdService = idService;
            this.IdClient = idClient;
            this.IdDoctor = idDoctor;
        }

        /// <summary>
        /// Идентификатор приема.
        /// </summary>
        public int IdAppointment { get; protected set; }

        /// <summary>
        /// Дата и время приема.
        /// </summary>
        public DateTime AppointmentDate { get; protected set; }

        /// <summary>
        /// Идентификатор услуги.
        /// </summary>
        public int IdService { get; protected set; }

        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int IdClient { get; protected set; }

        /// <summary>
        /// Идентификатор врача.
        /// </summary>
        public int IdDoctor { get; protected set; }

        /// <summary>
        /// Представление объекта прием в виде строки.
        /// </summary>
        /// <returns>Строковое представление приема.</returns>
        public override string ToString()
        {
            return $"{this.AppointmentDate} {this.IdService} {this.IdClient} {this.IdDoctor}".Trim();
        }
    }
}
