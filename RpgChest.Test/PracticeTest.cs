using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Moq;
using RpgChest;
using RpgChest.ItemChoose;
using RpgChest.Models;
using RpgChest.Models.Enums;


namespace RpgChest.Test
{
    public class PracticeTest
    {
        [Fact]
        public void Test1()
        {
            //TESTING//
            //Arrange (make obj, prop, needed to make test)
            int a = 1;
            int b = 4;
            
            //Act (logic of test)
            
            int value = a + b;
            int value2 = 5;
            //Assert (for e.g. compare or check values)

            Assert.Equal(value2,value);
  
            // only for practice
        }

        [Fact]
        public void GearRandomMethod_Test()
        {
           
            //Arrange
            GearItemChoose expected = GearItemChoose.Legs;
            ArmorItemBuilder armBuild = new ArmorItemBuilder();

            //Act
            GearItemChoose result = armBuild.GearRandomMethod(3);


            //Assert

            Assert.Equal(expected, result);



        }

       







    }

}
