namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Dentistry.Core;
    using NUnit.Framework;

    [TestFixture]
    internal class SpecializingMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var specializing = new Specializing(2, "Ортодонт");

            // act & assert
            new PersistenceSpecification<Specializing>(this.Session)
                .VerifyTheMappings(specializing);
        }
    }
}