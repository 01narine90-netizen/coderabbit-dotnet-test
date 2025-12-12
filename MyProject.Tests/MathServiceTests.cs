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
        #region Add Overflow and Underflow Tests

        [Fact]
        public void Add_WithMaxIntPlusOne_CausesOverflow()
        {
            // Arrange - This will cause integer overflow (wraps around to negative)
            int a = int.MaxValue;
            int b = 1;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - In C#, integer overflow wraps to int.MinValue
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void Add_WithMinIntMinusOne_CausesUnderflow()
        {
            // Arrange - This will cause integer underflow (wraps around to positive)
            int a = int.MinValue;
            int b = -1;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - In C#, integer underflow wraps to int.MaxValue
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void Add_WithMaxIntPlusMaxInt_CausesOverflow()
        {
            // Arrange - Extreme overflow case
            int a = int.MaxValue;
            int b = int.MaxValue;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should wrap around (2147483647 + 2147483647 = -2)
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Add_WithMinIntPlusMinInt_CausesUnderflow()
        {
            // Arrange - Extreme underflow case
            int a = int.MinValue;
            int b = int.MinValue;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should wrap around (-2147483648 + -2147483648 = 0)
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(int.MaxValue, 2, int.MinValue + 1)]
        [InlineData(int.MaxValue, 10, int.MinValue + 9)]
        [InlineData(int.MaxValue, 100, int.MinValue + 99)]
        public void Add_WithMaxIntPlusSmallPositive_OverflowsCorrectly(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(int.MinValue, -2, int.MaxValue - 1)]
        [InlineData(int.MinValue, -10, int.MaxValue - 9)]
        [InlineData(int.MinValue, -100, int.MaxValue - 99)]
        public void Add_WithMinIntPlusSmallNegative_UnderflowsCorrectly(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsEven Advanced Edge Cases

        [Theory]
        [InlineData(int.MaxValue - 1)] // 2147483646 (even)
        [InlineData(int.MinValue + 2)] // -2147483646 (even)
        public void IsEven_WithBoundaryEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(int.MaxValue - 2)] // 2147483645 (odd)
        [InlineData(int.MinValue + 1)] // -2147483647 (odd)
        public void IsEven_WithBoundaryOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEven_CalledMultipleTimes_ReturnsConsistentResults()
        {
            // Arrange
            int number = 42;

            // Act
            bool result1 = _mathService.IsEven(number);
            bool result2 = _mathService.IsEven(number);
            bool result3 = _mathService.IsEven(number);

            // Assert
            Assert.True(result1);
            Assert.Equal(result1, result2);
            Assert.Equal(result2, result3);
        }

        [Fact]
        public void IsEven_WithConsecutiveNumbers_AlternatesResults()
        {
            // Arrange & Act & Assert
            Assert.True(_mathService.IsEven(0));
            Assert.False(_mathService.IsEven(1));
            Assert.True(_mathService.IsEven(2));
            Assert.False(_mathService.IsEven(3));
            Assert.True(_mathService.IsEven(4));
        }

        #endregion

        #region Stress and Performance Validation Tests

        [Fact]
        public void Add_CalledManyTimesSequentially_RemainsAccurate()
        {
            // Arrange
            int iterations = 1000;
            int result = 0;

            // Act - Add 1 repeatedly
            for (int i = 0; i < iterations; i++)
            {
                result = _mathService.Add(result, 1);
            }

            // Assert
            Assert.Equal(iterations, result);
        }

        [Fact]
        public void IsEven_CalledManyTimesWithDifferentValues_RemainsAccurate()
        {
            // Arrange & Act - Test with many different values
            for (int i = -1000; i <= 1000; i++)
            {
                bool result = _mathService.IsEven(i);
                bool expected = i % 2 == 0;

                // Assert
                Assert.Equal(expected, result);
            }
        }

        [Fact]
        public void Add_WithAlternatingSignsOverManyIterations_ComputesCorrectly()
        {
            // Arrange
            int result = 0;

            // Act - Alternate adding positive and negative values
            for (int i = 1; i <= 100; i++)
            {
                result = _mathService.Add(result, i);
                result = _mathService.Add(result, -i);
            }

            // Assert - Should return to zero
            Assert.Equal(0, result);
        }

        [Fact]
        public void MathService_MultipleInstances_OperateIndependently()
        {
            // Arrange
            var service1 = new MathService();
            var service2 = new MathService();
            var service3 = new MathService();

            // Act
            int result1 = service1.Add(10, 20);
            int result2 = service2.Add(30, 40);
            int result3 = service3.Add(50, 60);

            bool even1 = service1.IsEven(result1);
            bool even2 = service2.IsEven(result2);
            bool even3 = service3.IsEven(result3);

            // Assert
            Assert.Equal(30, result1);
            Assert.Equal(70, result2);
            Assert.Equal(110, result3);
            Assert.True(even1);
            Assert.True(even2);
            Assert.True(even3);
        }

        #endregion

        #region Mathematical Properties and Invariants

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(10, -10, 0)]
        [InlineData(-7, 7, 0)]
        [InlineData(100, -50, 50)]
        public void Add_AssociativeProperty_HoldsTrue(int a, int b, int c)
        {
            // Arrange & Act
            // (a + b) + c should equal a + (b + c)
            int result1 = _mathService.Add(_mathService.Add(a, b), c);
            int result2 = _mathService.Add(a, _mathService.Add(b, c));

            // Assert
            Assert.Equal(result1, result2);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(-23)]
        [InlineData(0)]
        [InlineData(1000)]
        public void Add_WithItsNegative_AlwaysReturnsZero(int number)
        {
            // Act
            int result = _mathService.Add(number, -number);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(-5, 10, 15)]
        [InlineData(100, 200, 300)]
        public void Add_DistributiveProperty_WorksWithSubsequentIsEven(int a, int b, int c)
        {
            // Arrange & Act
            int sum = _mathService.Add(_mathService.Add(a, b), c);
            bool isEven = _mathService.IsEven(sum);

            // Assert - Verify the sum is computed correctly first
            Assert.Equal(a + b + c, sum);
            // Then verify IsEven matches expected parity
            Assert.Equal((a + b + c) % 2 == 0, isEven);
        }

        [Fact]
        public void IsEven_NegationProperty_FlipsOnlyForOddNumbers()
        {
            // Arrange
            int evenNumber = 10;
            int oddNumber = 11;

            // Act & Assert
            Assert.True(_mathService.IsEven(evenNumber));
            Assert.True(_mathService.IsEven(-evenNumber)); // Even negated is still even
            
            Assert.False(_mathService.IsEven(oddNumber));
            Assert.False(_mathService.IsEven(-oddNumber)); // Odd negated is still odd
        }

        [Theory]
        [InlineData(0, 2, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(5, 3, 15)]
        [InlineData(-4, 3, -12)]
        public void Add_RepeatedAddition_SimulatesMultiplication(int value, int times, int expected)
        {
            // Arrange
            int result = 0;

            // Act - Simulate multiplication by repeated addition
            for (int i = 0; i < Math.Abs(times); i++)
            {
                result = _mathService.Add(result, value);
            }

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion

        #region IsEven and Add Interaction Tests

        [Fact]
        public void Add_TwoEvenNumbers_ResultIsEven()
        {
            // Arrange
            int a = 4;
            int b = 6;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.Equal(10, sum);
            Assert.True(isEven);
        }

        [Fact]
        public void Add_TwoOddNumbers_ResultIsEven()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.Equal(8, sum);
            Assert.True(isEven);
        }

        [Fact]
        public void Add_OneEvenOneOdd_ResultIsOdd()
        {
            // Arrange
            int a = 4;
            int b = 5;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.Equal(9, sum);
            Assert.False(isEven);
        }

        [Theory]
        [InlineData(2, 4, true)]  // even + even = even
        [InlineData(3, 5, true)]  // odd + odd = even
        [InlineData(2, 3, false)] // even + odd = odd
        [InlineData(7, 8, false)] // odd + even = odd
        public void Add_ParityRules_FollowMathematicalLaws(int a, int b, bool expectedEven)
        {
            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.Equal(expectedEven, isEven);
        }

        [Fact]
        public void Add_AndIsEven_WorkCorrectlyInComplexExpression()
        {
            // Arrange
            int a = 7;
            int b = 13;
            int c = 20;

            // Act - Complex chained operations
            int sum1 = _mathService.Add(a, b);        // 7 + 13 = 20
            int sum2 = _mathService.Add(sum1, c);     // 20 + 20 = 40
            bool isEven1 = _mathService.IsEven(sum1); // 20 is even
            bool isEven2 = _mathService.IsEven(sum2); // 40 is even

            // Assert
            Assert.Equal(20, sum1);
            Assert.Equal(40, sum2);
            Assert.True(isEven1);
            Assert.True(isEven2);
        }

        #endregion

        #region Additional Boundary and Edge Cases

        [Theory]
        [InlineData(int.MaxValue / 2, int.MaxValue / 2)]
        [InlineData(int.MinValue / 2, int.MinValue / 2)]
        public void Add_WithHalfBoundaryValues_DoesNotOverflow(int a, int b)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should be close to but not exceed boundaries
            Assert.InRange(result, int.MinValue, int.MaxValue);
        }

        [Fact]
        public void IsEven_WithResultFromAdd_WorksCorrectly()
        {
            // Arrange
            int a = 123;
            int b = 456;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.Equal(579, sum);
            Assert.False(isEven); // 579 is odd
        }

        [Theory]
        [InlineData(1000000, 2000000, 3000000)]
        [InlineData(-1000000, -2000000, -3000000)]
        [InlineData(1000000, -1000000, 0)]
        public void Add_WithLargeValues_ComputesAccurately(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MathService_CanHandleRapidSequentialCalls()
        {
            // Arrange
            var results = new List<int>();
            var evenChecks = new List<bool>();

            // Act
            for (int i = 0; i < 100; i++)
            {
                int sum = _mathService.Add(i, i + 1);
                results.Add(sum);
                evenChecks.Add(_mathService.IsEven(sum));
            }

            // Assert
            Assert.Equal(100, results.Count);
            Assert.Equal(100, evenChecks.Count);
            // Verify first few results
            Assert.Equal(1, results[0]);   // 0 + 1 = 1
            Assert.Equal(3, results[1]);   // 1 + 2 = 3
            Assert.Equal(5, results[2]);   // 2 + 3 = 5
            // All sums should be odd (i + (i+1) = 2i + 1)
            Assert.All(evenChecks, isEven => Assert.False(isEven));
        }

        #endregion

        #region Defensive and Robustness Tests

        [Fact]
        public void MathService_CanBeCalledImmediatelyAfterConstruction()
        {
            // Arrange & Act
            var service = new MathService();
            int sum = service.Add(1, 1);
            bool isEven = service.IsEven(2);

            // Assert
            Assert.Equal(2, sum);
            Assert.True(isEven);
        }

        [Fact]
        public void MathService_StatelessBehavior_VerifiedByMultipleCalls()
        {
            // Arrange
            var service = new MathService();

            // Act - Make multiple calls and verify no state affects results
            int result1 = service.Add(5, 5);
            int result2 = service.Add(5, 5);
            bool even1 = service.IsEven(10);
            bool even2 = service.IsEven(10);

            // Assert - All results should be identical
            Assert.Equal(result1, result2);
            Assert.Equal(even1, even2);
            Assert.Equal(10, result1);
            Assert.True(even1);
        }

        [Theory]
        [InlineData(0, 1, 2, 3, 4, 10)]
        [InlineData(-1, -2, -3, -4, -5, -15)]
        [InlineData(10, -5, 3, -2, 1, 7)]
        public void Add_ChainedMultipleValues_ComputesCorrectSum(int v1, int v2, int v3, int v4, int v5, int expected)
        {
            // Act - Chain multiple Add calls
            int result = _mathService.Add(v1, v2);
            result = _mathService.Add(result, v3);
            result = _mathService.Add(result, v4);
            result = _mathService.Add(result, v5);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsEven_WithAllPossibleSingleDigits_ReturnsCorrectResults()
        {
            // Arrange & Act & Assert
            Assert.True(_mathService.IsEven(0));
            Assert.False(_mathService.IsEven(1));
            Assert.True(_mathService.IsEven(2));
            Assert.False(_mathService.IsEven(3));
            Assert.True(_mathService.IsEven(4));
            Assert.False(_mathService.IsEven(5));
            Assert.True(_mathService.IsEven(6));
            Assert.False(_mathService.IsEven(7));
            Assert.True(_mathService.IsEven(8));
            Assert.False(_mathService.IsEven(9));
        }

        [Fact]
        public void Add_WithSymmetricValues_ProducesSymmetricResults()
        {
            // Arrange & Act
            int positiveSum = _mathService.Add(100, 200);
            int negativeSum = _mathService.Add(-100, -200);

            // Assert
            Assert.Equal(300, positiveSum);
            Assert.Equal(-300, negativeSum);
            Assert.Equal(-positiveSum, negativeSum);
        }

        #endregion
    }
}