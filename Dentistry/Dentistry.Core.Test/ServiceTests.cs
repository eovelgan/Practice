// <copyright file="ServiceTests.cs" company="Вельганенко, Ольховская, Павлов">
// Copyright (c) Вельганенко, Ольховская, Павлов 2021. Учебные материалы.
// </copyright>

namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// Модульные тесты для класса <see cref="Service"/>.
    /// </summary>
    [TestFixture]
    public class ServiceTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var service = new ServiceName(1, "Первичный осмотр", 800);

            // act
            var result = service.ToString();

            // assert
            Assert.AreEqual("Первичный осмотр 800", result);
        }
    }
}