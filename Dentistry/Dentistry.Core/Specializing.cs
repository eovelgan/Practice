namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Спеециализация.
    /// </summary>
    public class Specializing
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Specializing"/>.
        /// </summary>
        /// <param name="idSpecializing"> Идентификатор специализации.</param>
        /// <param name="title"> Наименование должности.</param>
        public Specializing(int idSpecializing, string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException();
            }

            this.IdSpecializing = idSpecializing;
            this.Title = title.Trim();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Specializing"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Specializing()
        {
        }

        /// <summary>
        /// Идентификатор специализации.
        /// </summary>
        public virtual int IdSpecializing { get; protected set; }

        /// <summary>
        /// Наименование должности.
        /// </summary>
        public virtual string Title { get; protected set; }
    }
}
