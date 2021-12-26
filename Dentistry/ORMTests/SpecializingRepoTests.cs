namespace ORM.Tests
{
    using Dentistry.Core;
    using NUnit.Framework;
    using DataAccessLayer.Repository;

    [TestFixture]
    internal class SpecializingRepoTests : BaseMapTests
    {
        [Test]
        public void GetByTitle_ValidData_Success()
        {
            // arrange
            var repo = new SpecializingRepository(this.Session);

            var spec = new Specializing(1,"Ортодонт");
            // act
            repo.Save(spec);
            var result = repo.GetByTitle("Ортодонт");

            // assert
            Assert.AreEqual(spec.Title, result.Title);
        }

        public void Save_ValidData_Success()
        {
            // arrange
            var repo = new SpecializingRepository(this.Session);

            var spec = new Specializing(2, "Терапевт");

            // act & assert
            Assert.IsTrue(repo.Save(spec));
        }

    }
}
