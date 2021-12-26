namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Client"/>.
        /// </summary>
        /// <param name="idClient"> Идентификатор клиента.</param>
        /// <param name="telNum"> Номер телефона клиента.</param>
        /// <param name="location"> Место жительства.</param>
        /// <param name="medPolNum"> Медицинский полис.</param>
        /// <param name="passport"> Серия и номер паспорта.</param>
        /// <param name="birthDate"> Дата рождения.</param>
        /// <param name="lastName"> Фамилия.</param>
        /// <param name="firstName"> Имя.</param>
        /// <param name="middleName"> Отчетсво.</param>
        public Client(
            int idClient,
            string telNum,
            string location,
            string medPolNum,
            string passport,
            DateTime birthDate,
            string lastName,
            string firstName,
            string middleName = null)
            : base(idClient, lastName, firstName, middleName, telNum)

        {
            this.IdClient = idClient;
            this.TelNum = telNum ?? throw new ArgumentNullException(nameof(telNum));
            this.Location = location ?? throw new ArgumentNullException(nameof(location));
            this.MedPolNum = medPolNum ?? throw new ArgumentNullException(nameof(medPolNum));
            this.Passport = passport ?? throw new ArgumentNullException(nameof(passport));
            this.BirthDate = birthDate;
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Client"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Client()
        {
        }

        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public virtual int IdClient { get; protected set; }

        /// <summary>
        /// Место жительства.
        /// </summary>
        public virtual string Location { get; protected set; }

        /// <summary>
        /// Номер медицинского полиса.
        /// </summary>
        public virtual string MedPolNum { get; protected set; }

        /// <summary>
        /// Серия и номер паспорта.
        /// </summary>
        public virtual string Passport { get; protected set; }

        /// <summary>
        /// Дата рождения клиента.
        /// </summary>
        public virtual DateTime BirthDate { get; protected set; }

        /// <summary>
        /// Множество приемов.
        /// </summary>
        public virtual ISet<Appointment> Appointments { get; protected set; } = new HashSet<Appointment>();

        /// <summary>
        /// Представление объекта клиент в виде строки.
        /// </summary>
        /// <returns>Строковое представление клиента.</returns>
        public override string ToString()
        {
            return $"{this.FullName} {this.TelNum} {this.MedPolNum} {this.Passport} {this.BirthDate.Date}".Trim();
        }
    }
}
