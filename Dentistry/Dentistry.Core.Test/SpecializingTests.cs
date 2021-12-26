// <copyright file="ServiceTests.cs" company="Вельганенко, Ольховская, Павлов">
// Copyright (c) Вельганенко, Ольховская, Павлов 2021. Учебные материалы.
// </copyright>

namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// Модульные тесты для класса <see cref="Specializing"/>.
    /// </summary>
    [TestFixture]
    public class SpecializingTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var specializing = new Specializing(1, "Ортодонт");

            // act
            var result = specializing.ToString();

            // assert
            Assert.AreEqual("Ортодонт", result);
        }
    }
}