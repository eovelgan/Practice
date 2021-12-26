namespace ORM.Tests
{
    using DataAccessLayer.Repository;
    using Dentistry.Core;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    internal class AppoinmentRepoTests : BaseMapTests
    {
        [Test]
        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new AppointmentRepository(this.Session);
            DateTime birthDate = new DateTime(2021, 12, 21);
            var app = new Appointment(1, birthDate);

            // act & assert
            Assert.IsTrue(repo.Save(app));
        }
    }
}
