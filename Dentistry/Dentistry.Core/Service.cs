namespace Dentistry.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Услуга.
    /// </summary>
    public class Service
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
        public Service(int idservice, string title, decimal price)
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
        /// Идентификатор услуги.
        /// </summary>
        public int IdService { get; protected set; }

        /// <summary>
        /// Название услуги.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Цена услуги.
        /// </summary>
        public decimal Price { get; protected set; }

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
