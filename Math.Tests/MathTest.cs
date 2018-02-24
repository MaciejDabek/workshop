using System;
using Xunit;
using Shouldly;
using Math;

namespace Math.Tests
{
    public class MathTest
    {
        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data()
        {
            //arrange:
            var initialValue = 0;
            var math = new Math(initialValue);

            // act:


            // assert:
            math.Value.ShouldBe(initialValue);

        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            //arrange:
            var initialValue = 0;
            var math = new Math();

            // act:


            // assert:
            math.Value.ShouldBe(initialValue);

        }

        [Theory]
        [InlineData(5, 0)]
        [InlineData(-2, 3)]
        [InlineData(3, -9)]
        [InlineData(8, 100)]
        public void increase_new_value__when__add_value_to_earlier_value(int addingValue, int initialValue)
        {
            //arrange:
            //var initialValue = 0;
            var math = new Math(initialValue);
            //var addingValue = 5;
            // act:
            math.Add(addingValue);
            // assert:
            math.Value.ShouldBe(initialValue + addingValue);
        }


        [Theory]
        [InlineData(9000, 5)]
        //[InlineData(0, 5)]
        public void throw_exception__when__result_exceeds_9000(int addingValue, int initialValue)
        {// IT'S OVER 9000 !!!!

            //arrange:
            var math = new Math(initialValue);

            // act:
            Action act = () => math.Add(addingValue);

            // assert:
            Should.Throw<ITS_OVER_9000_Exception>(act);

        }        
    }
}
