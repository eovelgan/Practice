// <copyright file="ServiseTests.cs" company="Вельганенко, Ольховская">
// Copyright (c) Вельганенко, Ольховская 2021. Учебные материалы.
// </copyright>

namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// Модульные тесты для класса <see cref="Service"/>.
    /// </summary>
    [TestFixture]
    public class ServiseTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var service = new Service(1, "Первичный осмотр", 800);
            //act
            var result = service.ToString();
            //assert
            Assert.AreEqual("Первичный осмотр 800", result);
        }
    }
}