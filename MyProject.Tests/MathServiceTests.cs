using NUnit.Framework;
using MyProject;

namespace MyProject.Tests
{
    /// <summary>
    /// Comprehensive unit tests for the MathService class.
    /// Tests cover happy paths, edge cases, boundary conditions, and failure scenarios.
    /// Change Xunit to Nunit test framework
    /// </summary>
    [TestFixture]
    public class MathServiceTests
    {
        private MathService _mathService;

        [SetUp]
        public void SetUp()
        {
            _mathService = new MathService();
        }

        #region IsEven Tests

        [Test]
        public void IsEven_WithZero_ReturnsTrue()
        {
            // Arrange
            int number = 0;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsEven_WithPositiveEvenNumber_ReturnsTrue()
        {
            // Arrange
            int number = 4;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsEven_WithPositiveOddNumber_ReturnsFalse()
        {
            // Arrange
            int number = 5;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEven_WithNegativeEvenNumber_ReturnsTrue()
        {
            // Arrange
            int number = -4;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsEven_WithNegativeOddNumber_ReturnsFalse()
        {
            // Arrange
            int number = -5;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [TestCase(2)]
        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(999998)]
        public void IsEven_WithVariousPositiveEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [TestCase(1)]
        [TestCase(99)]
        [TestCase(1001)]
        [TestCase(999999)]
        public void IsEven_WithVariousPositiveOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [TestCase(-2)]
        [TestCase(-100)]
        [TestCase(-1000)]
        [TestCase(-999998)]
        public void IsEven_WithVariousNegativeEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [TestCase(-1)]
        [TestCase(-99)]
        [TestCase(-1001)]
        [TestCase(-999999)]
        public void IsEven_WithVariousNegativeOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEven_WithMaxInt_ReturnsFalse()
        {
            // Arrange - int.MaxValue is 2147483647 (odd)
            int number = int.MaxValue;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEven_WithMinInt_ReturnsTrue()
        {
            // Arrange - int.MinValue is -2147483648 (even)
            int number = int.MinValue;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsEven_WithTwo_ReturnsTrue()
        {
            // Arrange
            int number = 2;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsEven_WithOne_ReturnsFalse()
        {
            // Arrange
            int number = 1;

            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        #endregion

        #region Add Tests

        [Test]
        public void Add_WithPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-8));
        }

        [Test]
        public void Add_WithPositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -3;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_WithZeroAndPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            int a = 0;
            int b = 5;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_WithZeroAndNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            int a = 0;
            int b = -5;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Add_WithBothZeros_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_WithLargePositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 1000000;
            int b = 2000000;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(3000000));
        }

        [Test]
        public void Add_WithLargeNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -1000000;
            int b = -2000000;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-3000000));
        }

        [TestCase(1, 1, 2)]
        [TestCase(10, 20, 30)]
        [TestCase(100, 200, 300)]
        [TestCase(-10, 10, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void Add_WithVariousInputs_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Add_IsCommutative_ReturnsEqualResults()
        {
            // Arrange
            int a = 7;
            int b = 13;

            // Act
            int result1 = _mathService.Add(a, b);
            int result2 = _mathService.Add(b, a);

            // Assert
            Assert.That(result1, Is.EqualTo(result2));
        }

        [Test]
        public void Add_WithMaxIntAndZero_ReturnsMaxInt()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Add_WithMinIntAndZero_ReturnsMinInt()
        {
            // Arrange
            int a = int.MinValue;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void Add_WithIdentityProperty_ReturnsOriginalNumber()
        {
            // Arrange - Test additive identity (adding zero)
            int a = 42;
            int b = 0;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(a));
        }

        [Test]
        public void Add_WithInverses_ReturnsZero()
        {
            // Arrange - Test additive inverse
            int a = 15;
            int b = -15;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_WithNearMaxValues_HandlesCorrectly()
        {
            // Arrange - Values that won't overflow
            int a = int.MaxValue - 100;
            int b = 50;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(int.MaxValue - 50));
        }

        [Test]
        public void Add_WithNearMinValues_HandlesCorrectly()
        {
            // Arrange - Values that won't underflow
            int a = int.MinValue + 100;
            int b = -50;

            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(int.MinValue + 50));
        }

        #endregion

        #region Integration Tests

        [Test]
        public void MathService_CanBeInstantiatedMultipleTimes()
        {
            // Arrange & Act
            var service1 = new MathService();
            var service2 = new MathService();

            // Assert
            Assert.That(service1, Is.Not.Null);
            Assert.That(service2, Is.Not.Null);
            Assert.That(service1, Is.Not.SameAs(service2));
        }

        [Test]
        public void MathService_Methods_AreIndependent()
        {
            // Arrange
            var service = new MathService();

            // Act
            int sum = service.Add(4, 6);
            bool isEven = service.IsEven(sum);

            // Assert
            Assert.That(sum, Is.EqualTo(10));
            Assert.That(isEven, Is.True);
        }

        [Test]
        public void MathService_Methods_WorkWithChainedCalls()
        {
            // Arrange
            var service = new MathService();

            // Act
            int sum1 = service.Add(2, 3);
            int sum2 = service.Add(sum1, 5);
            bool isEven = service.IsEven(sum2);

            // Assert
            Assert.That(sum2, Is.EqualTo(10));
            Assert.That(isEven, Is.True);
        }

        #endregion

        #region Add Overflow and Underflow Tests

        [Test]
        public void Add_WithMaxIntPlusOne_CausesOverflow()
        {
            // Arrange - This will cause integer overflow (wraps around to negative)
            int a = int.MaxValue;
            int b = 1;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - In C#, integer overflow wraps to int.MinValue
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void Add_WithMinIntMinusOne_CausesUnderflow()
        {
            // Arrange - This will cause integer underflow (wraps around to positive)
            int a = int.MinValue;
            int b = -1;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - In C#, integer underflow wraps to int.MaxValue
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Add_WithMaxIntPlusMaxInt_CausesOverflow()
        {
            // Arrange - Extreme overflow case
            int a = int.MaxValue;
            int b = int.MaxValue;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should wrap around (2147483647 + 2147483647 = -2)
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Add_WithMinIntPlusMinInt_CausesUnderflow()
        {
            // Arrange - Extreme underflow case
            int a = int.MinValue;
            int b = int.MinValue;

            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should wrap around (-2147483648 + -2147483648 = 0)
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase(int.MaxValue, 2, int.MinValue + 1)]
        [TestCase(int.MaxValue, 10, int.MinValue + 9)]
        [TestCase(int.MaxValue, 100, int.MinValue + 99)]
        public void Add_WithMaxIntPlusSmallPositive_OverflowsCorrectly(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(int.MinValue, -2, int.MaxValue - 1)]
        [TestCase(int.MinValue, -10, int.MaxValue - 9)]
        [TestCase(int.MinValue, -100, int.MaxValue - 99)]
        public void Add_WithMinIntPlusSmallNegative_UnderflowsCorrectly(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion

        #region IsEven Advanced Edge Cases

        [TestCase(int.MaxValue - 1)] // 2147483646 (even)
        [TestCase(int.MinValue + 2)] // -2147483646 (even)
        public void IsEven_WithBoundaryEvenNumbers_ReturnsTrue(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.True);
        }

        [TestCase(int.MaxValue - 2)] // 2147483645 (odd)
        [TestCase(int.MinValue + 1)] // -2147483647 (odd)
        public void IsEven_WithBoundaryOddNumbers_ReturnsFalse(int number)
        {
            // Act
            bool result = _mathService.IsEven(number);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEven_CalledMultipleTimes_ReturnsConsistentResults()
        {
            // Arrange
            int number = 42;

            // Act
            bool result1 = _mathService.IsEven(number);
            bool result2 = _mathService.IsEven(number);
            bool result3 = _mathService.IsEven(number);

            // Assert
            Assert.That(result1, Is.True);
            Assert.That(result1, Is.EqualTo(result2));
            Assert.That(result2, Is.EqualTo(result3));
        }

        [Test]
        public void IsEven_WithConsecutiveNumbers_AlternatesResults()
        {
            // Arrange & Act & Assert
            Assert.That(_mathService.IsEven(0), Is.True);
            Assert.That(_mathService.IsEven(1), Is.False);
            Assert.That(_mathService.IsEven(2), Is.True);
            Assert.That(_mathService.IsEven(3), Is.False);
            Assert.That(_mathService.IsEven(4), Is.True);
        }

        #endregion

        #region Stress and Performance Validation Tests

        [Test]
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
            Assert.That(result, Is.EqualTo(iterations));
        }

        [Test]
        public void IsEven_CalledManyTimesWithDifferentValues_RemainsAccurate()
        {
            // Arrange & Act - Test with many different values
            for (int i = -1000; i <= 1000; i++)
            {
                bool result = _mathService.IsEven(i);
                bool expected = i % 2 == 0;

                // Assert
                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [Test]
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
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
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
            Assert.That(result1, Is.EqualTo(30));
            Assert.That(result2, Is.EqualTo(70));
            Assert.That(result3, Is.EqualTo(110));
            Assert.That(even1, Is.True);
            Assert.That(even2, Is.True);
            Assert.That(even3, Is.True);
        }

        #endregion

        #region Mathematical Properties and Invariants

        [TestCase(5, 3, 8)]
        [TestCase(10, -10, 0)]
        [TestCase(-7, 7, 0)]
        [TestCase(100, -50, 50)]
        public void Add_AssociativeProperty_HoldsTrue(int a, int b, int c)
        {
            // Arrange & Act
            // (a + b) + c should equal a + (b + c)
            int result1 = _mathService.Add(_mathService.Add(a, b), c);
            int result2 = _mathService.Add(a, _mathService.Add(b, c));

            // Assert
            Assert.That(result1, Is.EqualTo(result2));
        }

        [TestCase(15)]
        [TestCase(-23)]
        [TestCase(0)]
        [TestCase(1000)]
        public void Add_WithItsNegative_AlwaysReturnsZero(int number)
        {
            // Act
            int result = _mathService.Add(number, -number);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase(2, 3, 4)]
        [TestCase(-5, 10, 15)]
        [TestCase(100, 200, 300)]
        public void Add_DistributiveProperty_WorksWithSubsequentIsEven(int a, int b, int c)
        {
            // Arrange & Act
            int sum = _mathService.Add(_mathService.Add(a, b), c);
            bool isEven = _mathService.IsEven(sum);

            // Assert - Verify the sum is computed correctly first
            Assert.That(sum, Is.EqualTo(a + b + c));
            // Then verify IsEven matches expected parity
            Assert.That(isEven, Is.EqualTo((a + b + c) % 2 == 0));
        }

        [Test]
        public void IsEven_NegationProperty_FlipsOnlyForOddNumbers()
        {
            // Arrange
            int evenNumber = 10;
            int oddNumber = 11;

            // Act & Assert
            Assert.That(_mathService.IsEven(evenNumber), Is.True);
            Assert.That(_mathService.IsEven(-evenNumber), Is.True); // Even negated is still even
            
            Assert.That(_mathService.IsEven(oddNumber), Is.False);
            Assert.That(_mathService.IsEven(-oddNumber), Is.False); // Odd negated is still odd
        }

        [TestCase(0, 2, 0)]
        [TestCase(1, 2, 2)]
        [TestCase(5, 3, 15)]
        [TestCase(-4, 3, -12)]
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
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion

        #region IsEven and Add Interaction Tests

        [Test]
        public void Add_TwoEvenNumbers_ResultIsEven()
        {
            // Arrange
            int a = 4;
            int b = 6;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.That(sum, Is.EqualTo(10));
            Assert.That(isEven, Is.True);
        }

        [Test]
        public void Add_TwoOddNumbers_ResultIsEven()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.That(sum, Is.EqualTo(8));
            Assert.That(isEven, Is.True);
        }

        [Test]
        public void Add_OneEvenOneOdd_ResultIsOdd()
        {
            // Arrange
            int a = 4;
            int b = 5;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.That(sum, Is.EqualTo(9));
            Assert.That(isEven, Is.False);
        }

        [TestCase(2, 4, true)]  // even + even = even
        [TestCase(3, 5, true)]  // odd + odd = even
        [TestCase(2, 3, false)] // even + odd = odd
        [TestCase(7, 8, false)] // odd + even = odd
        public void Add_ParityRules_FollowMathematicalLaws(int a, int b, bool expectedEven)
        {
            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.That(isEven, Is.EqualTo(expectedEven));
        }

        [Test]
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
            Assert.That(sum1, Is.EqualTo(20));
            Assert.That(sum2, Is.EqualTo(40));
            Assert.That(isEven1, Is.True);
            Assert.That(isEven2, Is.True);
        }

        #endregion

        #region Additional Boundary and Edge Cases

        [TestCase(int.MaxValue / 2, int.MaxValue / 2)]
        [TestCase(int.MinValue / 2, int.MinValue / 2)]
        public void Add_WithHalfBoundaryValues_DoesNotOverflow(int a, int b)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert - Should be close to but not exceed boundaries
            Assert.That(result, Is.InRange(int.MinValue, int.MaxValue));
        }

        [Test]
        public void IsEven_WithResultFromAdd_WorksCorrectly()
        {
            // Arrange
            int a = 123;
            int b = 456;

            // Act
            int sum = _mathService.Add(a, b);
            bool isEven = _mathService.IsEven(sum);

            // Assert
            Assert.That(sum, Is.EqualTo(579));
            Assert.That(isEven, Is.False); // 579 is odd
        }

        [TestCase(1000000, 2000000, 3000000)]
        [TestCase(-1000000, -2000000, -3000000)]
        [TestCase(1000000, -1000000, 0)]
        public void Add_WithLargeValues_ComputesAccurately(int a, int b, int expected)
        {
            // Act
            int result = _mathService.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
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
            Assert.That(results.Count, Is.EqualTo(100));
            Assert.That(evenChecks.Count, Is.EqualTo(100));
            // Verify first few results
            Assert.That(results[0], Is.EqualTo(1));   // 0 + 1 = 1
            Assert.That(results[1], Is.EqualTo(3));   // 1 + 2 = 3
            Assert.That(results[2], Is.EqualTo(5));   // 2 + 3 = 5
            // All sums should be odd (i + (i+1) = 2i + 1)
            Assert.That(evenChecks, Has.All.False);
        }

        #endregion

        #region Defensive and Robustness Tests

        [Test]
        public void MathService_CanBeCalledImmediatelyAfterConstruction()
        {
            // Arrange & Act
            var service = new MathService();
            int sum = service.Add(1, 1);
            bool isEven = service.IsEven(2);

            // Assert
            Assert.That(sum, Is.EqualTo(2));
            Assert.That(isEven, Is.True);
        }

        [Test]
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
            Assert.That(result1, Is.EqualTo(result2));
            Assert.That(even1, Is.EqualTo(even2));
            Assert.That(result1, Is.EqualTo(10));
            Assert.That(even1, Is.True);
        }

        [TestCase(0, 1, 2, 3, 4, 10)]
        [TestCase(-1, -2, -3, -4, -5, -15)]
        [TestCase(10, -5, 3, -2, 1, 7)]
        public void Add_ChainedMultipleValues_ComputesCorrectSum(int v1, int v2, int v3, int v4, int v5, int expected)
        {
            // Act - Chain multiple Add calls
            int result = _mathService.Add(v1, v2);
            result = _mathService.Add(result, v3);
            result = _mathService.Add(result, v4);
            result = _mathService.Add(result, v5);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsEven_WithAllPossibleSingleDigits_ReturnsCorrectResults()
        {
            // Arrange & Act & Assert
            Assert.That(_mathService.IsEven(0), Is.True);
            Assert.That(_mathService.IsEven(1), Is.False);
            Assert.That(_mathService.IsEven(2), Is.True);
            Assert.That(_mathService.IsEven(3), Is.False);
            Assert.That(_mathService.IsEven(4), Is.True);
            Assert.That(_mathService.IsEven(5), Is.False);
            Assert.That(_mathService.IsEven(6), Is.True);
            Assert.That(_mathService.IsEven(7), Is.False);
            Assert.That(_mathService.IsEven(8), Is.True);
            Assert.That(_mathService.IsEven(9), Is.False);
        }

        [Test]
        public void Add_WithSymmetricValues_ProducesSymmetricResults()
        {
            // Arrange & Act
            int positiveSum = _mathService.Add(100, 200);
            int negativeSum = _mathService.Add(-100, -200);

            // Assert
            Assert.That(positiveSum, Is.EqualTo(300));
            Assert.That(negativeSum, Is.EqualTo(-300));
            Assert.That(negativeSum, Is.EqualTo(-positiveSum));
        }

        #endregion
    }
}
