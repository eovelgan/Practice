namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Dentistry.Core;
    using NUnit.Framework;
    using System;

    [TestFixture]
    internal class ClientMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(2, "89168230972", "г.Сергиев Посад", "5004000855480965", "4619249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");

            // act & assert
            new PersistenceSpecification<Client>(this.Session)
                .VerifyTheMappings(client);
        }
    }
}