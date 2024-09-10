using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        //Success test of the valide string into double number
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber, out bool success);
            Assert.AreEqual(5, convertedNumber);
        }
        //Testing the fail condition of the conversion from string to double number
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber, out bool success);
            Assert.AreEqual(5, convertedNumber);
        }
        //Success test of the addition operator
       [TestMethod]
       public void ConvertsValidStringInputOperationAdd()
        {
            string inputAddition = "+";
            bool convertedAddition = InputConverter.ValidOperation(inputAddition);
            Assert.AreEqual(true, convertedAddition);
        }
        //Success test of the soustraction operator
        [TestMethod]
        public void ConvertsValidStringInputOperationSoustraction()
        {
            string inputSoustraction = "-";
            bool convertedSoustraction = InputConverter.ValidOperation(inputSoustraction);
            Assert.AreEqual(true, convertedSoustraction);
        }
        //Success test of the multiplayer operator
        [TestMethod]
        public void ConvertsValidStringInputOperationMultipliyer()
        {
            string inputMultipliyer = "*";
            bool convertedMultipliyer = InputConverter.ValidOperation(inputMultipliyer);
            Assert.AreEqual(true, convertedMultipliyer);
        }
        //Success test of the Divide operator
        [TestMethod]
        public void ConvertsValidStringInputOperationDivide()
        {
            string inputDivide = "/";
            bool convertedDivide = InputConverter.ValidOperation(inputDivide);
            Assert.AreEqual(true, convertedDivide);
        }

        [TestMethod]
        public void FailsConvertsValidStringInputOperation()
        {
            string inputOperation = "ark";
            bool convertedOperation = InputConverter.ValidOperation(inputOperation);
            Assert.AreEqual(true, convertedOperation);

        }
    }
   

}
