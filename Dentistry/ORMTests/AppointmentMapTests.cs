namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Dentistry.Core;
    using NUnit.Framework;
    using System;

    [TestFixture]
    internal class AppointmentMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            DateTime appointmenthDate = new DateTime(2021, 11, 25, 13, 20, 0);
            var appointment = new Appointment(2, appointmenthDate);

            // act & assert
            new PersistenceSpecification<Appointment>(this.Session)
                .VerifyTheMappings(appointment);
        }
    }
}