using System;
using UpperCase;
using Shouldly;

public class UpperCaseTestFixture {
    UpperCaseChange _upperCaseChange;
    String _text;
    public UpperCaseTestFixture () {
        _upperCaseChange = new UpperCaseChange ();
    }

    internal void SetTextToChange (string text) {
        _text = text;
    }

    internal void assert_text_are_upper_case (string restult) {
        var upperCase = _text.ToUpper();

        restult.ShouldBe(upperCase);
    }

    internal string act () {
        return _upperCaseChange.Change(_text);
    }
}