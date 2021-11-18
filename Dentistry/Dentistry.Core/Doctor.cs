namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Доктор.
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Doctor"/>.
        /// </summary>
        /// <param name="idDoctor"> Идентификатор врача.</param>
        /// <param name="lastName"> Фамилия врача.</param>
        /// <param name="firsttName"> Имя врача.</param>
        /// <param name="middleName"> Отчество врача.</param>
        /// <param name="position"> Должность врача.</param>
        public Doctor(int idDoctor, string position, string lastName, string firsttName, string middleName = null)
        {
            this.IdDoctor = idDoctor;
            this.Position = position ?? throw new ArgumentNullException(nameof(position));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.FirsttName = firsttName ?? throw new ArgumentNullException(nameof(firsttName));
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Идентификатор врача.
        /// </summary>
        public int IdDoctor { get; protected set; }

        /// <summary>
        /// Должность врача.
        /// </summary>
        public string Position { get; protected set; }

        /// <summary>
        /// Фамилия врача.
        /// </summary>
        public string LastName { get; protected set; }

        /// <summary>
        /// Имя врача.
        /// </summary>
        public string FirsttName { get; protected set; }

        /// <summary>
        /// Отчество врача.
        /// </summary>
        public string MiddleName { get; protected set; }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName => $"{this.LastName} {this.FirsttName} {this.MiddleName}".Trim();

        /// <summary>
        /// Представление объекта врач в виде строки.
        /// </summary>
        /// <returns>Строковое представление врача.</returns>
        public override string ToString()
        {
            return $"{this.Position} {this.FullName}".Trim();
        }
    }
}
