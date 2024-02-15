using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string actual = AdjacentEqual.Sum(emptyList);
        string expected = string.Empty;
        // Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> ints = new List<int> {
        1, 2, 3 , 4, 5
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "1 2 3 4 5";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int> {
        2,2,3,3,5,5
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "4 6 10";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));


    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> ints = new List<int> {
        2,2,2,2
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "8";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int> 
        {
        2,2,3,1
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "4 3 1";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>
        {
        2,6,7,7
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "2 6 14";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>
        {
        1,7,7,3
        };
        // Act
        string actual = AdjacentEqual.Sum(ints);
        string expected = "1 14 3";
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
