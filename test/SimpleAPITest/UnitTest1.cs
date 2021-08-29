using System;
using Xunit;
using simpleAPI.controller;



namespace SimpleAPITest
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
         public void GetReturnsByName()
        {
            var returnValue = controller.Get(1) ;
            AssertEqual("Les Jackson", returnValue.value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
