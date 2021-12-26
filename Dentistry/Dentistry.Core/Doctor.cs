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
     //   private Specializing specializing;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Doctor"/>.
        /// </summary>
        /// <param name="idDoctor"> Идентификатор врача.</param>
        /// <param name="telNum"> Номер телефона.</param>
        /// <param name="lastName"> Фамилия врача.</param>
        /// <param name="firstName"> Имя врача.</param>
        /// <param name="middleName"> Отчество врача.</param>
        public Doctor(
            int idDoctor,
            string telNum,
            string lastName,
            string firstName,
            string middleName = null)
            : base (idDoctor,lastName, firstName, middleName, telNum)
        {
            this.IdDoctor = idDoctor;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.TelNum = telNum;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Doctor"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Doctor()
        {
        }

        /// <summary>
        /// Идентификатор врача.
        /// </summary>
        public virtual int IdDoctor { get; protected set; }

        /// <summary>
        /// Специализация врача.
        /// </summary>
        public virtual Specializing Specializing
        {get; protected set;
        }

        /// <summary>
        /// Добавить доктора в специализацию.
        /// </summary>
        public virtual bool AddDoctorToSpec(Specializing specializing)
        {
            this.Specializing?.Doctors.Remove(this);

            this.Specializing = specializing ?? throw new ArgumentNullException(nameof(specializing));

            this.Specializing = specializing;

            return this.Specializing.Doctors.Add(this);
        }

        /// <summary>
        /// Множество приемов.
        /// </summary>
        public virtual ISet<Appointment> Appointments { get; protected set; } = new HashSet<Appointment>();

        /// <summary>
        /// Представление объекта врач в виде строки.
        /// </summary>
        /// <returns>Строковое представление врача.</returns>
        public override string ToString()
        {
            return $"{this.FullName}".Trim();
        }
    }
}
