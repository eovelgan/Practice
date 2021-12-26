namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Услуга.
    /// </summary>
    public class ServiceName
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Service"/>.
        /// </summary>
        /// <param name="idservice">Идентификатор услуги.</param>
        /// <param name="title">Название.</param>
        /// <param name="price">Цена услуги.</param>
        /// <exception cref="ArgumentNullException">
        /// В случае если <paramref name="title"/> <see langword="null"/> или пустая срока <see cref="string.Empty"/>.
        /// </exception>
        public ServiceName(int idservice, string title, decimal price)
        {
            if (price < 0 || string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException();
            }

            this.IdService = idservice;
            this.Title = title.Trim();
            this.Price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Service"/>.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected ServiceName()
        {
        }

        /// <summary>
        /// Идентификатор услуги.
        /// </summary>
        public virtual int IdService { get; protected set; }

        /// <summary>
        /// Название услуги.
        /// </summary>
        public virtual string Title { get; protected set; }

        /// <summary>
        /// Цена услуги.
        /// </summary>
        public virtual decimal Price { get; protected set; }

        /// <summary>
        /// Множество приемов.
        /// </summary>
        public virtual ISet<Appointment> Appointments { get; protected set; } = new HashSet<Appointment>();

        /// <summary>
        /// Представление объекта услуга в виде строки.
        /// </summary>
        /// <returns>Строковое представление услуги.</returns>
        public override string ToString()
        {
            return $"{this.Title} {this.Price}".Trim();
        }
    }
}
