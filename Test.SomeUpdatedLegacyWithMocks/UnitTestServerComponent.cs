using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SomeLegacyWithMocks.LegacyServer;
using SomeUpdatedLegacyWithMocks.Interfaces;

namespace Test.SomeUpdatedLegacyWithMocks
{
    [TestClass]
    public class UnitTestServerComponent
    {
        private IServerInstance _server;
        private IServerComponent _serverComponent;

        [TestInitialize]
        public void Arrange()
        {
            var serverMock = new Mock<IServerInstance>();
            serverMock.Setup(s => s.GetServerInstance()).Returns("New Server For Tests");

            _server = serverMock.Object;

            var serverComponentMock = new Mock<ServerComponent>(_server) { CallBase = true };
            serverComponentMock.Setup(s => s.Execute(It.IsAny<int>()));
           
            _serverComponent = serverComponentMock.Object;
        }

        [TestMethod]
        public void TestMethodExecuteSomeFunction()
        {
            //arrange
            var timeout = 1000;
            var expectedResult = $"Function executed about {timeout} seconds on server {_server.GetServerInstance()}";

            //act
            var result = _serverComponent.ExecuteSomeFunction(timeout);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod]
        public void TestMethodExecuteAnotherFunction()
        {
            //arrange
            var timeout = 1000;
            var expectedResult = $"Function executed about {timeout * 2} seconds on server {_server.GetServerInstance()}";

            //act
            var result = _serverComponent.ExecuteAnotherFunction(timeout);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
