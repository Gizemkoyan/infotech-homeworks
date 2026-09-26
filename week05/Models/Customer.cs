namespace week05.Models;

public class Customer
{
        private string _firstName = "";
        private string _lastName = "";
        private int _age;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ad boş olamaz.");

                _firstName = value.Trim();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Soyad boş olamaz.");

                _lastName = value.Trim();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException(nameof(value), "Yaş 0 ile 120 arasında olmalıdır.");

                _age = value;
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        // 18 yaş ve üzerindeki müşteriler yetişkin etkinliklerine katılabilir.
        public bool CanAttendAdultEvents => Age >= 18;

        public Customer()
        {
        }

        public Customer(string firstName, string lastName)
            : this(firstName, lastName, 18)
        {
        }

        public Customer(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintSummary()
    {
        Console.WriteLine($"Müşteri: {FullName} — Yaş: {Age}");
    }

    public decimal CalculateTicketPrice(decimal basePrice)
    {
        if (basePrice <= 0)
            throw new ArgumentOutOfRangeException(nameof(basePrice), "Bilet fiyatı sıfırdan büyük olmalıdır.");

        return basePrice;
    }

    public decimal CalculateTicketPrice(decimal basePrice, int ticketCount)
    {
        if (basePrice <= 0)
            throw new ArgumentOutOfRangeException(nameof(basePrice), "Bilet fiyatı sıfırdan büyük olmalıdır.");

        if (ticketCount <= 0)
            throw new ArgumentOutOfRangeException(nameof(ticketCount), "Bilet adedi sıfırdan büyük olmalıdır.");

        return basePrice * ticketCount;
    }

        protected string GetIdentityText()
    {
        return $"{FullName} ({Age} yaş)";
    }

    public virtual string GetCustomerType()
    {
        return "Standart Müşteri";
    }

    public virtual string GetAccessMessage()
    {
        return $"{GetIdentityText()} — Standart giriş hakkı.";
    }
}