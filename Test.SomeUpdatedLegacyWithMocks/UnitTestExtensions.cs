using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SomeUpdatedLegacyWithMocks.Interfaces;
using SomeUpdatedLegacyWithMocks.Server;

namespace Test.SomeUpdatedLegacyWithMocks
{
    [TestClass]
    public class UnitTestExtensions
    {
        private IExtensionsFactory _extensionsFactory;

        [TestInitialize]
        public void Arrange()
        {
            var hulkExtension = new Mock<IExtensionsBase>();
            hulkExtension.Setup(h => h.ExtensionName).Returns("Hulk");
            hulkExtension.Setup(h => h.IsExtensionReady).Returns(true);

            var widowExtension = new Mock<IExtensionsBase>();
            widowExtension.Setup(h => h.ExtensionName).Returns("Widow");
            widowExtension.Setup(h => h.IsExtensionReady).Returns(false);

            var extensionsFactory = new Mock<IExtensionsFactory>();
            extensionsFactory.Setup(e => e.GetWidowExtension(It.IsAny<IServerInstance>())).Returns(widowExtension.Object);
            extensionsFactory.Setup(e => e.GetHulkExtension(It.IsAny<IServerInstance>())).Returns(hulkExtension.Object);

            _extensionsFactory = extensionsFactory.Object;
        }

        [TestMethod]
        public void TestHulk()
        {
            //arrange
            var expectedResult = "Extension Hulk status: true";

            //act
            var server = new ServerInstance("Extensions test", _extensionsFactory);
            var result = server.LoadHulkExtension();

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void TestWidow()
        {
            //arrange
            var expectedResult = "Extension Widow status: false";

            //act
            var server = new ServerInstance("Extensions test", _extensionsFactory);
            var result = server.LoadWidowExtension();

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
