using week05.Interfaces;

namespace week05.Strategies;

public class FixedAmountDiscount : IDiscountStrategy
{
    public decimal DiscountAmount { get; }

    public FixedAmountDiscount(decimal discountAmount)
    {
        if (discountAmount <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(discountAmount),
                "İndirim tutarı sıfırdan büyük olmalıdır.");

        DiscountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Tutar negatif olamaz.");

        return Math.Max(0, amount - DiscountAmount);
    }
}