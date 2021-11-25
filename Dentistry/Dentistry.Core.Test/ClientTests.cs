namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;
    using System;


    /// <summary>
    /// Модульные тесты для класса <see cref="Specializing"/>.
    /// </summary>
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            DateTime birthDate = new DateTime(1999, 12, 21);
            var client = new Client(1, "89168230972", "г.Сергиев Посад", "5004 0008 5548 0965", "4619 249944", birthDate, "Гаврилов", "Андрей", "Сергеевич");
            //act
            var result = client.ToString();
            //assert
            Assert.AreEqual("Гаврилов Андрей Сергеевич 89168230972 5004 0008 5548 0965 4619 249944 21.12.1999 0:00:00", result);
        }
    }
}