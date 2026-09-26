namespace week05.Models;

public class StudentCustomer : Customer
{
    public string StudentNumber { get; set; }

    public StudentCustomer(
        string firstName,
        string lastName,
        int age,
        string studentNumber)
        : base(firstName, lastName, age)
    {
        StudentNumber = studentNumber;
    }

    public override string GetCustomerType()
    {
        return "Öğrenci Müşteri";
    }

    public override string GetAccessMessage()
    {
        return $"{GetIdentityText()} — Öğrenci giriş hakkı.";
    }
}