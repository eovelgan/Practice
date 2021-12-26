namespace ORM.Tests
{
    using Dentistry.Core;
    using NUnit.Framework;
    using DataAccessLayer.Repository;

    [TestFixture]
    internal class ServiceNameRepoTests : BaseMapTests
    {
        [Test]
        public void GetByTitle_ValidData_Success()
        {
            // arrange
            var repo = new ServiceNameRepository(this.Session);

            var service = new ServiceName(1, "Первичный осмотр",800);
            // act
            repo.Save(service);
            var result = repo.GetByTitle("Первичный осмотр");

            // assert
            Assert.AreEqual(service.Title, result.Title);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new ServiceNameRepository(this.Session);

            var service = new ServiceName(2, "Удаление зуба мудрости",2500);

            // act & assert
            Assert.IsTrue(repo.Save(service));
        }

    }
}
