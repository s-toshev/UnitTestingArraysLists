using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string actual = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] newArr = new int[] { 3 };

        // Act
        string actual = Reverse.ReverseArray(newArr);

        // Assert
        Assert.That(actual, Is.EqualTo("3"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {

        // Arrange
        int[] newArr = new int[] { 3, 7, 9, 12, 17 };

        // Act
        string actual = Reverse.ReverseArray(newArr);
        string expected = "17 12 9 7 3";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
