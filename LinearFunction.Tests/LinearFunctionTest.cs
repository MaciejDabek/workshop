using System;
using Xunit;
using Shouldly;

namespace LinearFunction.Tests
{
    public class LinearFunctionTest
    {
        [Fact]
        public void set_default_value_a_to_1__when__is_not_setted_and_b_to_0_when_is_not_setted()
        {
            //arrange:
            var fun = new LinearFunction(new parametr_a(), new parametr_b());
            //act:

            //assert:
            fun.parametr_a.Value.ShouldBe(1);
            fun.parametr_b.Value.ShouldBe(0);
        }

        [Fact]
        public void formula_length_greater_than_0__when____a_and_b_are_setted()
        {
            //arrange:
            var fun = new LinearFunction(new parametr_a(2), new parametr_b(-7));

            //act:
            var printView = fun.PrintViewOfFormula();

            //assert:
            printView.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public void throw_exception__when__a_and_b_set_to_0()
        {
            //arrange:
            var fun = new LinearFunction(new parametr_a(0), new parametr_b(0));

            //act:
            Action action = () => fun.PrintViewOfFormula();

            //assert:
            Should.Throw<FunctionParametrs_a_and_b_SetToZeroException>(action);
        }        
    }
}
