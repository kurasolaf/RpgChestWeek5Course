using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using RpgChest;
using RpgChest.Helpers;



namespace RpgChest.Test
{
    public class HelpersTest
    {

        [Fact]
        public void InputIntValidationIsTrue_Test()
        {
            
            //Arrange
            bool expected = true;
            string input = "5";

            InputIntValidation inputIntValidation = new InputIntValidation();
            //Act
            bool actual = inputIntValidation.InputNumber(input);

            //Assert
            Assert.Equal(expected,actual);


        }
        [Fact]
        public void InputIntValidationIsFalse_Test()
        {
            bool expected = false;
            string input = "p";

            InputIntValidation inputIntValidation = new InputIntValidation();


            bool actual = inputIntValidation.InputNumber(input);

            Assert.Equal(expected,actual);


        }

        [Fact]
        public void InputIntValidationDoubleIsFalse_Test()
        {
            bool expected = false;
            string input = "1,5";

            InputIntValidation inputIntValidation = new InputIntValidation();


            bool actual = inputIntValidation.InputNumber(input);

            Assert.Equal(expected, actual);


        }
        [Fact]
        public void InputMinusIntValidationIsFalse_Test()
        {
            bool expected = false;
            string input = "-4";

            InputIntValidation inputIntValidation = new InputIntValidation();


            bool actual = inputIntValidation.InputNumber(input);
              

            Assert.Equal(expected, actual);

        //Found to repair, Cant be -4 (cant have less then 0)
        }


    }
}
