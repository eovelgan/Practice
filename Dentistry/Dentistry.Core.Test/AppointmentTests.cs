namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;
    using System;

    /// <summary>
    /// Модульные тесты для класса <see cref="Appointment"/>.
    /// </summary>
    [TestFixture]
    public class AppointmentTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            DateTime appointmenthDate = new DateTime(2021, 11, 25, 13, 20, 0);
            var appointment = new Appointment(1, appointmenthDate);

            // act
            var result = appointment.ToString();

            // assert
            Assert.AreEqual("25.11.2021 13:20:00", result);
        }
    }
}