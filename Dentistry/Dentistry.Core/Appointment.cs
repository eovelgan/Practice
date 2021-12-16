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
        private Service service;
        private Doctor doctor;
        private Client client;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Appointment"/>.
        /// </summary>
        /// <param name="idAppointment"> Идентификатор приема.</param>
        /// <param name="appointmentDate"> Дата и время приема.</param>
        /// <param name="service"> Услуга. .</param>
        /// <param name="doctor"> Врач.</param>
        /// <param name="client"> Клиент.</param>
        public Appointment(
            int idAppointment,
            DateTime appointmentDate,
            Service service,
            Doctor doctor,
            Client client)

        {
            this.IdAppointment = idAppointment;
            this.AppointmentDate = appointmentDate;
            this.service = service;
            this.doctor = doctor;
            this.client = client;
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
        public virtual Service Service
        {
            get => this.service;
            protected set
            {
                if (this.service is null)
                {
                    throw new ArgumentNullException(nameof(this.service));
                }

                this.Service = this.service;
            }
        }

        /// <summary>
        /// Врач.
        /// </summary>
        public virtual Doctor Doctor
        {
            get => this.doctor;
            protected set
            {
                if (this.doctor is null)
                {
                    throw new ArgumentNullException(nameof(this.doctor));
                }

                this.Doctor = this.doctor;
            }
        }

        /// <summary>
        /// Клиент.
        /// </summary>
        public virtual Client Client
        {
            get => this.client;
            protected set
            {
                if (this.client is null)
                {
                    throw new ArgumentNullException(nameof(this.client));
                }

                this.Client = this.client;
            }
        }

        /// <summary>
        /// Представление объекта прием в виде строки.
        /// </summary>
        /// <returns>Строковое представление приема.</returns>
        public override string ToString()
        {
            return $"{this.AppointmentDate} {this.Service} {this.Client.FullName} {this.Doctor.FullName} {this.Doctor.Specializing.Title}".Trim();
        }
    }
}
