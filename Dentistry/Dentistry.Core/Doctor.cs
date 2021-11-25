namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Доктор.
    /// </summary>
    public class Doctor : Person
    {
        private Specializing specializing;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Doctor"/>.
        /// </summary>
        /// <param name="idDoctor"> Идентификатор врача.</param>
        /// <param name="specializing"> Специализация врача.</param>
        /// <param name="telNum"> Номер телефона.</param>
        /// <param name="lastName"> Фамилия врача.</param>
        /// <param name="firstName"> Имя врача.</param>
        /// <param name="middleName"> Отчество врача.</param>
        public Doctor(
            int idDoctor,
            Specializing specializing,
            string telNum,
            string lastName,
            string firstName,
            string middleName = null)
            : base (lastName, firstName, middleName, telNum)
        {
            this.IdDoctor = idDoctor;
            this.specializing = specializing;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.TelNum = telNum;
        }

        /// <summary>
        /// Идентификатор врача.
        /// </summary>
        public int IdDoctor { get; protected set; }

        /// <summary>
        /// Специализация врача.
        /// </summary>
        public virtual Specializing Specializing
        {
            get => this.specializing;
            protected set
            {
                if (this.specializing is null)
                {
                    throw new ArgumentNullException(nameof(specializing));
                }

                this.Specializing = this.specializing;
            }
        }

        /// <summary>
        /// Представление объекта врач в виде строки.
        /// </summary>
        /// <returns>Строковое представление врача.</returns>
        public override string ToString()
        {
            return $"{this.Specializing.Title} {this.FullName}".Trim();
        }
    }
}
