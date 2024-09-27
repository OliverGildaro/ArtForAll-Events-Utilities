namespace CASPAR.Shared.Exceptions.Tests
{
    using ArtForAll.Shared.ExceptionHandler;
    using ArtForAll.Shared.ExceptionHandler.Exceptions;
    using CASPAR.Shared.ExceptionHandler.CustomExceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ExceptionHandlerBaseTest
    {
        IExceptionHandlerBase ExceptionHandler { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            ExceptionHandler = new MathExceptionHandler();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public async Task Handle_DivideByZero_DivideByZeroExceptionThrown()
        {
            await ExceptionHandler.HandleAsync(() => { return DummyHelper.Division(4, 0); });
        }

        [TestMethod]
        public async Task Handle_DivideByZero_DivideByZeroExceptionThrown2()
        {
            var result = await ExceptionHandler.HandleAsync(() => { return DummyHelper.Division(4, 2); });
        }


        [TestMethod]
        public async Task Handle_StringReturn_Success_ThrowNoException()
        {
            string value1 = "Hello";
            string value2 = "All";
            var value = await ExceptionHandler.HandleAsync(() => { return DummyHelper.ProcessStringInformation(value1, value2); });
            Assert.AreEqual($"{value1}-{value2}", value);
        }

        [TestMethod]
        [ExpectedException(typeof(UnHandlerException))]
        public async Task Handle_NoRecordException_ReturnUnHandlerException()
        {
            EmptyExceptionHandler newEmptyException = new EmptyExceptionHandler();
            await newEmptyException.HandleAsync(() => { return DummyHelper.Division(4, 0); });
        }

        [TestMethod]
        public void HandlerCount_Is0WhenTheHandlersIsEmpty_Success()
        {
            EmptyExceptionHandler newEmptyException = new EmptyExceptionHandler();
            Assert.AreEqual(0, newEmptyException.handlers.Count);
        }

        [TestMethod]
        public void HandlerCount_Is2WhenTheHandlersHasRepeated()
        {
            EmptyExceptionHandler addCatchesException = new EmptyExceptionHandler();
            addCatchesException.Catch<DivideByZeroException>(ex => { throw ex; });
            addCatchesException.Catch<NullReferenceException>(ex => { throw ex; });
            addCatchesException.Catch<DivideByZeroException>(ex => { throw new Exception(); });
            Assert.AreEqual(2, addCatchesException.handlers.Count);
        }
    }
}
