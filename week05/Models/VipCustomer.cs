namespace week05.Models;

public class VipCustomer : Customer
{
    public int VipLevel { get; set; }

    public VipCustomer(
        string firstName,
        string lastName,
        int age,
        int vipLevel)
        : base(firstName, lastName, age)
    {
        VipLevel = vipLevel;
    }

    public override string GetCustomerType()
    {
        return "VIP Müşteri";
    }

    public override string GetAccessMessage()
    {
        return $"{GetIdentityText()} — VIP giriş hakkı.";
    }
}