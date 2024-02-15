using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.Zero);
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] ints =
            {
            4,4,4,4,4,4
        };
        // Act
        int result=EvenOddSubtraction.FindDifference(ints);
        int expected = 24;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] ints =
            {
           7,7,7,7,7,7,7
        };
        // Act
        int result = EvenOddSubtraction.FindDifference(ints);
        int expected = 49;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] ints =
            {
           7,7,7,2,7,2,7,7,2,7
        };
        // Act
        int result = EvenOddSubtraction.FindDifference(ints);
        int expected = 43;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
