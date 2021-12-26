namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Dentistry.Core;
    using NUnit.Framework;

    [TestFixture]
    internal class DoctorMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var doctor = new Doctor(2, "89162241625", "Квашонки", "Алексей", "Васильевич");

            // act & assert
            new PersistenceSpecification<Doctor>(this.Session)
                .VerifyTheMappings(doctor);
        }
    }
}