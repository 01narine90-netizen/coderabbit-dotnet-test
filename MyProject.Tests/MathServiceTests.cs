using Xunit;
using MyProject;

namespace MyProject.Tests
{
    /// <summary>
    /// Comprehensive unit tests for the MathService class.
    /// Tests cover happy paths, edge cases, boundary conditions, and failure scenarios.
    /// </summary>
    public class MathServiceTests
    {
        private readonly MathService _mathService;

        public MathServiceTests()
        {
            _mathService = new MathService();
        }

        #region IsEven Tests

        [Fact]
        public void IsEven_WithZero_ReturnsTrue()
        {
            // Arrange
            int number = 0;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_WithPositiveEvenNumber_ReturnsTrue()
        {
            // Arrange
            int number = 4;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_WithPositiveOddNumber_ReturnsFalse()
        {
            // Arrange
            int number = 5;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEven_WithNegativeEvenNumber_ReturnsTrue()
        {
            // Arrange
            int number = -4;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_WithNegativeOddNumber_ReturnsFalse()
        {
            // Arrange
            int number = -5;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(999998)]
        public void IsEven_WithVariousPositiveEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(99)]
        [InlineData(1001)]
        [InlineData(999999)]
        public void IsEven_WithVariousPositiveOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-100)]
        [InlineData(-1000)]
        [InlineData(-999998)]
        public void IsEven_WithVariousNegativeEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-99)]
        [InlineData(-1001)]
        [InlineData(-999999)]
        public void IsEven_WithVariousNegativeOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEven_WithMaxInt_ReturnsFalse()
        {
            // Arrange - int.MaxValue is 2147483647 (odd)
            int number = int.MaxValue;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEven_WithMinInt_ReturnsTrue()
        {
            // Arrange - int.MinValue is -2147483648 (even)
            int number = int.MinValue;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_WithTwo_ReturnsTrue()
        {
            // Arrange
            int number = 2;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_WithOne_ReturnsFalse()
        {
            // Arrange
            int number = 1;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region Add Tests

        [Fact]
        public void Add_WithPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_WithPositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_WithZeroAndPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            int a = 0;
            int b = 5;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_WithZeroAndNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            int a = 0;
            int b = -5;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_WithBothZeros_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_WithLargePositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 1000000;
            int b = 2000000;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(3000000, result);
        }

        [Fact]
        public void Add_WithLargeNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -1000000;
            int b = -2000000;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(-3000000, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(10, 20, 30)]
        [InlineData(100, 200, 300)]
        [InlineData(-10, 10, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(0, 0, 0)]
        public void Add_WithVariousInputs_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_IsCommutative_ReturnsEqualResults()
        {
            // Arrange
            int a = 7;
            int b = 13;

            // Act
            int result1 = _mathService.Add(a, b);
            int result2 = _mathService.Add(b, a);

            // Assert
            Assert.Equal(result1, result2);
        }

        [Fact]
        public void Add_WithMaxIntAndZero_ReturnsMaxInt()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void Add_WithMinIntAndZero_ReturnsMinInt()
        {
            // Arrange
            int a = int.MinValue;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void Add_WithIdentityProperty_ReturnsOriginalNumber()
        {
            // Arrange - Test additive identity (adding zero)
            int a = 42;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(a, result);
        }

        [Fact]
        public void Add_WithInverses_ReturnsZero()
        {
            // Arrange - Test additive inverse
            int a = 15;
            int b = -15;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_WithNearMaxValues_HandlesCorrectly()
        {
            // Arrange - Values that won't overflow
            int a = int.MaxValue - 100;
            int b = 50;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(int.MaxValue - 50, result);
        }

        [Fact]
        public void Add_WithNearMinValues_HandlesCorrectly()
        {
            // Arrange - Values that won't underflow
            int a = int.MinValue + 100;
            int b = -50;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(int.MinValue + 50, result);
        }

        #endregion

        #region Integration Tests

        [Fact]
        public void MathService_CanBeInstantiatedMultipleTimes()
        {
            // Arrange & Act
            var service1 = new MathService();
            var service2 = new MathService();

            // Assert
            Assert.NotNull(service1);
            Assert.NotNull(service2);
            Assert.NotSame(service1, service2);
        }

        [Fact]
        public void MathService_Methods_AreIndependent()
        {
            // Arrange
            var service = new MathService();

            // Act
            int sum = service.Add(4, 6);
            bool isEven = service.IsEven(sum);

            // Assert
            Assert.Equal(10, sum);
            Assert.True(isEven);
        }

        [Fact]
        public void MathService_Methods_WorkWithChainedCalls()
        {
            // Arrange
            var service = new MathService();

            // Act
            int sum1 = service.Add(2, 3);
            int sum2 = service.Add(sum1, 5);
            bool isEven = service.IsEven(sum2);

            // Assert
            Assert.Equal(10, sum2);
            Assert.True(isEven);
        }

        #endregion
    }
}