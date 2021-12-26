namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Dentistry.Core;
    using NUnit.Framework;

    [TestFixture]
    internal class ServiceNamegMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var service = new ServiceName(2, "Первичный осмотр",2500);

            // act & assert
            new PersistenceSpecification<ServiceName>(this.Session)
                .VerifyTheMappings(service);
        }
    }
}