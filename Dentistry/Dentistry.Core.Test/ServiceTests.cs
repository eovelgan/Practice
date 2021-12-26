// <copyright file="ServiceTests.cs" company="�����������, ����������, ������">
// Copyright (c) �����������, ����������, ������ 2021. ������� ���������.
// </copyright>

namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// ��������� ����� ��� ������ <see cref="Service"/>.
    /// </summary>
    [TestFixture]
    public class ServiceTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var service = new ServiceName(1, "��������� ������", 800);

            // act
            var result = service.ToString();

            // assert
            Assert.AreEqual("��������� ������ 800", result);
        }
    }
}