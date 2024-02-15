using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);
        double expected = 42.0;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { 40, 20, 60};

        // Act
        double result = Average.CalculateAverage(array);
        double expected = 40.0;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { -30, -20, -10 };

        // Act
        double result = Average.CalculateAverage(array);
        double expected = -20;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { -30, -20, 20 };

        // Act
        double result = Average.CalculateAverage(array);
        double expected = -10;
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
