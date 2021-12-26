namespace ORM.Tests
{
    using Dentistry.Core;
    using NUnit.Framework;
    using DataAccessLayer.Repository;

    [TestFixture]
    internal class DoctorRepoTests : BaseMapTests
    {
        [Test]
        public void GetByTitle_ValidData_Success()
        {
            // arrange
            var repo = new DoctorRepository(this.Session);

            var doctor = new Doctor(1, "89162241625", "Квашонкин", "Алексей", "Васильевич");
            // act
            repo.Save(doctor);
            var result = repo.GetByLastname("Квашонкин");

            // assert
            Assert.AreEqual(doctor.LastName, result.LastName);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new DoctorRepository(this.Session);

            var doctor = new Doctor(1, "89162241625", "Квашонки", "Алексей", "Васильевич");

            // act & assert
            Assert.IsTrue(repo.Save(doctor));
        }

    }
}
