namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// Модульные тесты для класса <see cref="Doctor"/>.
    /// </summary>
    [TestFixture]
    public class DoctorTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var doctor = new Doctor(1, "89156548554", "Дулов", "Александр", "Владимирович");

            // act
            var result = doctor.ToString();

            // assert
            Assert.AreEqual("Дулов Александр Владимирович", result);
        }

        [Test]
        public void AddDoctor_ValidData_Success()
        {
            // arrange
            var doctor = new Doctor(1, "89156548554", "Дулов", "Александр", "Владимирович");
            var specializing = new Specializing(1, "Ортодонт");

            // act
            var actual = doctor.AddDoctorToSpec(specializing);

            // assert
            Assert.IsTrue(actual);
        }
    }
}