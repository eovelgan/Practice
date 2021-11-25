namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;
    using System;

    /// <summary>
    /// Модульные тесты для класса <see cref="Service"/>.
    /// </summary>
    [TestFixture]
    public class AppointmentTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var service = new Service(1, "Первичный осмотр", 800);
            var specializing = new Specializing(1, "Ортодонт");
            var doctor = new Doctor(1, specializing, "89156548554", "Дулов", "Александр", "Владимирович");
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004 0008 5548 0965", "4619 249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");
            DateTime appointmenthDate = new DateTime(2021, 11, 25, 13, 20, 0);
            var appointment = new Appointment(1, appointmenthDate, service, doctor, client);
            //act
            var result = appointment.ToString();
            //assert
            Assert.AreEqual("25.11.2021 13:20:00 Первичный осмотр 800 Гаврилов Андрей Сергеевич Дулов Александр Владимирович Ортодонт", result);
        }
    }
}