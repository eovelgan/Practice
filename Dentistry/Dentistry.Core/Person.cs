namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Человек.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Person"/>.
        /// </summary>
        /// <param name="lastName"> Фамилия.</param>
        /// <param name="firstName"> Имя.</param>
        /// <param name="middleName"> Отчетство.</param>
        /// <param name="telNum"> Номер телефона.</param>
        public Person(int id, string telNum, string lastName, string firstName, string middleName = null)
        {
            this.Id = id;
           this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
           this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
           this.MiddleName = middleName;
           this.TelNum = telNum ?? throw new ArgumentNullException(nameof(telNum));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Person"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Person()
        {
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public virtual int Id { get; protected set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public virtual string LastName { get; protected set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public virtual string FirstName { get; protected set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public virtual string MiddleName { get; protected set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public virtual string TelNum { get; protected set; }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public virtual string FullName => this.MiddleName != null
            ? $"{this.LastName} {this.FirstName} {this.MiddleName}".Trim()
            : $"{this.LastName} {this.FirstName}".Trim();
    }
}
