namespace MyProject
{
    public class MathService
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

public decimal CalculateDiscount(decimal price, bool isLoyalUser)
{
    if (!isLoyalUser) return 0;

    decimal discount = price * 0.10m; // 10% rule

    // THE BUSINESS LOGIC (The Cap)
    if (discount > 20)
    {
        return 20;
    }

    return discount;
}
        
    }
}
