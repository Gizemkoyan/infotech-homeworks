using week05.Interfaces;

namespace week05.Strategies;

public class PercentageDiscount : IDiscountStrategy
{
    public decimal Percentage { get; }

    public PercentageDiscount(decimal percentage)
    {
        if (percentage <= 0 || percentage > 100)
            throw new ArgumentOutOfRangeException(
                nameof(percentage),
                "İndirim oranı 0 ile 100 arasında olmalıdır.");

        Percentage = percentage;
    }

    public decimal ApplyDiscount(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Tutar negatif olamaz.");

        return amount - (amount * Percentage / 100);
    }
}