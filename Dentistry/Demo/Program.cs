// <copyright file="Program.cs" company="Вельганенко, Ольховская,Павлов">
// Copyright (c) Вельганенко, Ольховская, Павлов 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using System.Linq;
    using DataAccessLayer;
    using DataAccessLayer.ORM;
    using DataAccessLayer.Repository;
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
            var service = new ServiceName(1, "Первичный осмотр", 800);
            var service2 = new ServiceName(2, "Удаление зуба мудрости", 2500);
            var specializing = new Specializing(1, "Ортодонт");
            var specializing2 = new Specializing(2, "Гигиенист");
            var specializing3 = new Specializing(3, "Терапевт");
            var specializing4 = new Specializing(4, "Хирург");
            var doctor = new Doctor(1,  "89156548554", "Дулов", "Александр", "Владимирович");
            var doctor2 = new Doctor(2, "34634643666", "Гаврилов", "Андрей", "Сергеевич");
            var doctor3 = new Doctor(3, "43564645455", "Шамутило", "Алексей", "Игоревич");
            var doctor4 = new Doctor(4, "54656546546", "Кострецов", "Михаил", "Евгеньевич");
            doctor.AddDoctorToSpec(specializing);
            doctor2.AddDoctorToSpec(specializing2);
            doctor3.AddDoctorToSpec(specializing3);
            doctor4.AddDoctorToSpec(specializing4);
            Console.WriteLine($"{doctor} {specializing}");
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004000855480965", "4619249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");
            DateTime appointmenthDate = new DateTime(2021, 11, 25, 13, 20, 0);
            var appointment = new Appointment(1, appointmenthDate);
            DateTime appointmenthDate2 = new DateTime(2021, 11, 30, 13, 00, 0);
            var appointment2 = new Appointment(1, appointmenthDate2);
            appointment.AddAppToDoctor(doctor);
            appointment2.AddAppToDoctor(doctor4);
            appointment.AddAppToClient(client);
            appointment2.AddAppToClient(client);
            appointment.AddAppToService(service);
            appointment2.AddAppToService(service2);
            var settings = new Settings();
            settings.AddDatabaseServer(@"LAPTOP-14PAJF0H");
            settings.AddDatabaseName("Dentistry");
            using var sessionFactory = FluentNHibernateConfigurator
    .GetSessionFactory(settings, showSql: true);
            using (var session = sessionFactory.OpenSession())
            {
                session.Save(specializing);
                session.Save(specializing2);
                session.Save(specializing3);
                session.Save(specializing4);
                session.Save(doctor);
                session.Save(doctor2);
                session.Save(doctor3);
                session.Save(doctor4);
                session.Save(service);
                session.Save(service2);
                session.Save(client);
                session.Save(appointment);
                session.Save(appointment2);
                session.Flush();
            }

            using (var session = sessionFactory.OpenSession())
            {
                var repoSpec = new SpecializingRepository(session);

                var repoDoctor = new DoctorRepository(session);
                Console.WriteLine("All specializings:");
                repoSpec.GetAll()
                   .ToList().ForEach(Console.WriteLine);
                Console.WriteLine(new string('-', 25));

                Console.WriteLine();
            }
        }
    }
}
