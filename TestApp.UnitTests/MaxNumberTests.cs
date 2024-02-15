using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> list = new List<int> { 3 };

        //Act
        int actual = MaxNumber.FindMax(list);


        //Assert

        Assert.That(list[0], Is.EqualTo(actual));

    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> list = new List<int> { 3, 5, 7 };

        //Act
        int expected = 7;

        int actual = MaxNumber.FindMax(list);

        //Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {

        //Arrange
        List<int> list = new List<int> { -13, -5, -71 };

        //Act
        int expected = -5;

        int actual = MaxNumber.FindMax(list);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> list = new List<int> { -13, -5, -71, 8, 15, -21, 1, 0 };

        //Act
        int expected = 15;

        int actual = MaxNumber.FindMax(list);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> list = new List<int> { -13, -5, -71, 8, 33, 15, -21, 1, 0, 33 };

        //Act
        int expected = 33;

        int actual = MaxNumber.FindMax(list);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}
