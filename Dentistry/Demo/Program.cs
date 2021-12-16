// <copyright file="Program.cs" company="Вельганенко, Ольховская">
// Copyright (c) Вельганенко, Ольховская 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using DataAccessLayer;
    using DataAccessLayer.ORM;
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
            var specializing = new Specializing(1, "Ортодонт");
            var doctor = new Doctor(1, specializing, "89156548554", "Дулов", "Александр", "Владимирович");
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004 0008 5548 0965", "4619 249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");
            DateTime appointmenthDate = new DateTime(2021, 11, 25, 13, 20, 0);
            var appointment = new Appointment(1, appointmenthDate, service, doctor, client);
           
            var settings = new Settings();
            settings.AddDatabaseServer(@"LAPTOP-14PAJF0H");
            settings.AddDatabaseName("Dentistry");

            Console.WriteLine(doctor);
            Console.WriteLine(service);
            Console.WriteLine(client);
            Console.WriteLine(appointment);
        }
    }
}
