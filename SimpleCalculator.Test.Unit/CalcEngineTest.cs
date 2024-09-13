using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalcEngineTest
    {
        //Success test of the valide factorial operation
        [TestMethod]
        public void ValidateFactorial()
        {
            double inputNumber = 5;
            double convertedNumber = CalcLibrary.CalcEngine.factorial(inputNumber);
            Assert.AreEqual(120, convertedNumber);
        }

        //Fail test of the valide factorial operation
        [TestMethod]
        public void FailValidateFactorial()
        {
            double inputNumber = 5;
            double convertedNumber = CalcLibrary.CalcEngine.factorial(inputNumber);
            Assert.AreEqual(110, convertedNumber);
        }

        //Success test of the valide + operation
        [TestMethod]
        public void FirstCalculate_additionTests()
        {
            String operatorAdd = "+";
            double inputNumber1 = 5;
            double inputNumber2 = 10;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorAdd, inputNumber2, inputNumber1);
            Assert.AreEqual(15, convertedNumber);
        }

        //Success test of the valide add operation
        [TestMethod]
        public void SecondCalculate_additionTests()
        {
            String operatorAdd = "add";
            double inputNumber1 = 5;
            double inputNumber2 = 10;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorAdd, inputNumber2, inputNumber1);
            Assert.AreEqual(15, convertedNumber);
        }

        //Success test of the valide plus operation
        [TestMethod]
        public void ThirdCalculate_additionTests()
        {
            String operatorAdd = "plus";
            double inputNumber1 = 5;
            double inputNumber2 = 10;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorAdd, inputNumber2, inputNumber1);
            Assert.AreEqual(15, convertedNumber);
        }
        //Success test of the valide - operation
        [TestMethod]
        public void FirstCalculate_SoustractTests()
        {
            String operatorSubstract = "-";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorSubstract, inputNumber1, inputNumber2);
            Assert.AreEqual(5, convertedNumber);
        }
        //Success test of the valide substract operation
        [TestMethod]
        public void SecondCalculate_SoustractTests()
        {
            String operatorSubstract = "substract";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorSubstract, inputNumber1, inputNumber2);
            Assert.AreEqual(5, convertedNumber);
        }
        //Success test of the valide moins operation
        [TestMethod]
        public void ThirdCalculate_SoustractTests()
        {
            String operatorSoustract = "moins";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorSoustract, inputNumber1, inputNumber2);
            Assert.AreEqual(5, convertedNumber);
        }
        //Success test of the valide * operation
        [TestMethod]
        public void FirstCalculate_MultiplyTests()
        {
            String operatorMultiply = "*";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorMultiply, inputNumber2, inputNumber1);
            Assert.AreEqual(50, convertedNumber);
        }
        //Success test of the valide multiply operation
        [TestMethod]
        public void SecondCalculate_MultiplyTests()
        {
            String operatorMultiply = "multiply";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorMultiply, inputNumber2, inputNumber1);
            Assert.AreEqual(50, convertedNumber);
        }
        //Success test of the valide / operation
        [TestMethod]
        public void FirstCalculate_DivideTests()
        {
            String operatorDivide = "/";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorDivide, inputNumber1, inputNumber2);
            Assert.AreEqual(2, convertedNumber);
        }
        //Success test of the valide divide operation
        [TestMethod]
        public void SecondCalculate_DivideTests()
        {
            String operatorDivide = "divide";
            double inputNumber1 = 10;
            double inputNumber2 = 5;
            double convertedNumber = CalcLibrary.CalcEngine.Calculate(operatorDivide, inputNumber1, inputNumber2);
            Assert.AreEqual(2, convertedNumber);
        }

        //Testing if the method actually throw an exception when the dividing number is 0
        [TestMethod]
        public void zeroValue_DivideTests()
        {
            String operatorDivide = "/";
            double inputNumber1 = 10;
            double inputNumber2 = 0;
            Assert.ThrowsException<DivideByZeroException>(() => CalcLibrary.CalcEngine.Calculate(operatorDivide, inputNumber1, inputNumber2));
            
        }
    }
}
