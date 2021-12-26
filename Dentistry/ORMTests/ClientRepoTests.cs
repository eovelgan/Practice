namespace ORM.Tests
{
    using Dentistry.Core;
    using NUnit.Framework;
    using DataAccessLayer.Repository;
    using System;

    [TestFixture]
    internal class ClientRepoTests : BaseMapTests
    {
        [Test]
        public void GetByTitle_ValidData_Success()
        {
            // arrange
            var repo = new ClientRepository(this.Session);
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004000855480965", "4619249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");
            // act
            repo.Save(client);
            var result = repo.GetByLastname("Гаврилов");

            // assert
            Assert.AreEqual(client.LastName, result.LastName);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new ClientRepository(this.Session);
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004000855480965", "4619249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");

            // act & assert
            Assert.IsTrue(repo.Save(client));
        }

    }
}
