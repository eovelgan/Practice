namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// Модульные тесты для класса <see cref="Specializing"/>.
    /// </summary>
    [TestFixture]
    public class DoctorTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var specializing = new Specializing(1, "Ортодонт");
            var doctor = new Doctor(1, specializing, "89156548554", "Дулов", "Александр", "Владимирович");
            //act
            var result = doctor.ToString();
            //assert
            Assert.AreEqual("Ортодонт Дулов Александр Владимирович", result);
        }

    }
}