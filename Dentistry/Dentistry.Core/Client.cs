namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Client"/>.
        /// </summary>
        /// <param name="idClient"> Идентификатор клиента.</param>
        /// <param name="telNum"> Номер телефона клиента.</param>
        /// <param name="location"> Место рождения клиента.</param>
        /// <param name="medPolNum"> Медицинский полис.</param>
        /// <param name="passport"> Серия и номер паспорта.</param>
        /// <param name="year"> Год рождения.</param>
        /// <param name="month"> Месяц рождения.</param>
        /// <param name="day"> День рождения.</param>
        /// <param name="lastName"> Фамилия.</param>
        /// <param name="firsttName"> Имя.</param>
        /// <param name="middleName"> Отчетсво.</param>
        public Client(int idClient, string telNum, string location, string medPolNum, string passport, int year,
                      int month, int day, string lastName, string firsttName, string middleName = null)
        {
            this.IdClient = idClient;
            this.TelNum = telNum ?? throw new ArgumentNullException(nameof(telNum));
            this.Location = location ?? throw new ArgumentNullException(nameof(location));
            this.MedPolNum = medPolNum ?? throw new ArgumentNullException(nameof(medPolNum));
            this.Passport = passport ?? throw new ArgumentNullException(nameof(passport));
            this.BirthDate = new DateTime(year, month, day);
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FirsttName = firsttName ?? throw new ArgumentNullException(nameof(firsttName));
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int IdClient { get; protected set; }

        /// <summary>
        /// Фамилия клиента.
        /// </summary>
        public string LastName { get; protected set; }

        /// <summary>
        /// Имя клиента.
        /// </summary>
        public string FirsttName { get; protected set; }

        /// <summary>
        /// Отчество клиента.
        /// </summary>
        public string MiddleName { get; protected set; }

        /// <summary>
        /// Номер телефона клиента.
        /// </summary>
        public string TelNum { get; protected set; }

        /// <summary>
        /// Место жительства.
        /// </summary>
        public string Location { get; protected set; }

        /// <summary>
        /// Номер медицинского полиса.
        /// </summary>
        public string MedPolNum { get; protected set; }

        /// <summary>
        /// Серия и номер паспорта.
        /// </summary>
        public string Passport { get; protected set; }

        /// <summary>
        /// Дата рождения клиента.
        /// </summary>
        public DateTime BirthDate { get; protected set; }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName => $"{this.LastName} {this.FirsttName} {this.MiddleName}".Trim();

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
