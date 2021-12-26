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
    //    private ServiceName service;
    //    private Doctor doctor;
    //    private Client client;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Appointment"/>.
        /// </summary>
        /// <param name="idAppointment"> Идентификатор приема.</param>
        /// <param name="appointmentDate"> Дата и время приема.</param>
        public Appointment(
            int idAppointment,
            DateTime appointmentDate
            )

        {
            this.IdAppointment = idAppointment;
            this.AppointmentDate = appointmentDate;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Appointment"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Appointment()
        {
        }


        /// <summary>
        /// Идентификатор приема.
        /// </summary>
        public virtual int IdAppointment { get; protected set; }

        /// <summary>
        /// Дата и время приема.
        /// </summary>
        public virtual DateTime AppointmentDate { get; protected set; }

        /// <summary>
        /// Услуга.
        /// </summary>
        public virtual ServiceName ServiceName { get; protected set; }

        /// <summary>
        /// Врач.
        /// </summary>
        public virtual Doctor Doctor { get; protected set; }

        /// <summary>
        /// Клиент.
        /// </summary>
        public virtual Client Client { get; protected set; }

        public virtual bool AddAppToDoctor(Doctor doctor)
        {
            this.Doctor?.Appointments.Remove(this);

            this.Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));

            this.Doctor = doctor;

            return this.Doctor.Appointments.Add(this);
        }

        public virtual bool AddAppToClient(Client client)
        {
            this.Client?.Appointments.Remove(this);

            this.Client = client ?? throw new ArgumentNullException(nameof(client));

            this.Client = client;

            return this.Client.Appointments.Add(this);
        }

        public virtual bool AddAppToService(ServiceName service)
        {
            this.ServiceName?.Appointments.Remove(this);

            this.ServiceName = service ?? throw new ArgumentNullException(nameof(service));

            this.ServiceName = service;

            return this.ServiceName.Appointments.Add(this);
        }

        /// <summary>
        /// Представление объекта прием в виде строки.
        /// </summary>
        /// <returns>Строковое представление приема.</returns>
        public override string ToString()
        {
            return $"{this.AppointmentDate}".Trim();
        }
    }
}
