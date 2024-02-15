using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> ints = new List<int>
        {
        1
        };
        // Act
        List<int> result = GaussTrick.SumPairs(ints);

        // Assert
        CollectionAssert.AreEqual(ints, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> ints = new List<int> { 1, 1, 2, 2, 3, 3 };
        // Act
        List<int> actual = GaussTrick.SumPairs(ints);
        List<int> expected = new List<int> { 4, 4, 4 };
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> ints = new List<int> { 1, 1, 2, 3, 3 };
        // Act
        List<int> actual = GaussTrick.SumPairs(ints);
        List<int> expected = new List<int> { 4, 4, 2 };
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> ints = new List<int> { 1, 1, 2, 2, 3, 3, 43, 43, 7, 7, 7, 7, 7, 7 };
        // Act
        List<int> actual = GaussTrick.SumPairs(ints);
        List<int> expected = new List<int> { 8, 8, 9, 9, 10, 10, 86 };
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> ints = new List<int> { 1, 1, 2, 2, 3, 3, 9, 43, 43, 7, 7, 7, 7, 7, 7 };
        // Act
        List<int> actual = GaussTrick.SumPairs(ints);
        List<int> expected = new List<int> { 8, 8, 9, 9, 10, 10, 52, 43 };
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
