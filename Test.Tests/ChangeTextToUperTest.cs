using System;
using Xunit;
using Shouldly;

namespace Test.Tests
{
    public class ChangeTextToUperTest
    {
        [Theory]
        [InlineData("test1")]
        [InlineData("test2")]
        [InlineData("test3")]
        [InlineData("test4")]
        public void change_text_upper_case(string value)
        {
            //arrange
            _fixture.SetTextToChange(value);

            //act
            var restult = act();

            //assert
            _fixture.assert_text_are_upper_case(restult);
        }

        private string act(){
            return _fixture.act();
        }

        public ChangeTextToUperTest()
        {
            _fixture = new UpperCaseTestFixture();
        }

        private UpperCaseTestFixture _fixture;
    }
}
