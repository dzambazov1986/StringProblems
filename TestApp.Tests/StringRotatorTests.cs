using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = string.Empty;
        var positions = 5;

        // Act
        var result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {

        // Arrange
        var input = "TestString";
        var positions = 0;

        // Act
        var result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        var input = "TestString";
        var positions = 3;
        var expected = "ingTestStr";

        // Act
        var result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
    var input = "TestString";
    var positions = -1;
    var expected = "gTestStrin";

    // Act
    var result = StringRotator.RotateRight(input, positions);

    // Assert
    Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        var input = "abcdef";
        var positions = 10;
        var expected = "cdefab";

        // Act
        var result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
