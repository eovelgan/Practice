// <copyright file="ServiseTests.cs" company="�����������, ����������">
// Copyright (c) �����������, ���������� 2021. ������� ���������.
// </copyright>

namespace Dentistry.Core.Test
{
    using NUnit.Framework;
    using Dentistry.Core;

    /// <summary>
    /// ��������� ����� ��� ������ <see cref="Service"/>.
    /// </summary>
    [TestFixture]
    public class ServiseTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var service = new Service(1, "��������� ������", 800);
            //act
            var result = service.ToString();
            //assert
            Assert.AreEqual("��������� ������ 800", result);
        }
    }
}