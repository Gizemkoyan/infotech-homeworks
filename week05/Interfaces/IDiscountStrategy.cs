namespace week05.Interfaces;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}