// <copyright file="Program.cs" company="Вельганенко, Ольховская">
// Copyright (c) Вельганенко, Ольховская 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using Dentistry.Core;

    /// <summary>
    /// Исполняемый файл.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        private static void Main()
        {
            var service = new Service(1, "Первичный осмотр", 800);
            var doctor = new Doctor(1, "Ортодонт", "Дулов", "Александр", "Владимирович");
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004 0008 5548 0965", "4619 249944", 1999, 12, 21, "Гаврилов", "Андрей", "Сергеевич");
            var appointment = new Appointment(1, 2021, 11, 18, 13, 20, 1, 1, 1);
            Console.WriteLine(doctor);
            Console.WriteLine(service);
            Console.WriteLine(client);
            Console.WriteLine(appointment);
        }
    }
}
