using week05.Models;
using week05.Services;
using week05.Plans;
using week05.Strategies;
using week05.Interfaces;
using week05.Access;
using week05.Enums;
namespace week05;


class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Gizem", "Koyan", 25);

        Customer customer2 = new Customer
        {
            FirstName = "Zeynep",
            LastName = "Kaya",
            Age = 22
        };

        Console.WriteLine($"Müşteri: {customer1.FullName} — Yaş: {customer1.Age}");
        Console.WriteLine($"Müşteri: {customer2.FullName} — Yaş: {customer2.Age}");
        customer1.PrintSummary();

        decimal tekBiletFiyati = customer1.CalculateTicketPrice(500);
        decimal ucBiletFiyati = customer1.CalculateTicketPrice(500, 3);

        Console.WriteLine($"Tek bilet fiyatı: {tekBiletFiyati:C}");
        Console.WriteLine($"3 bilet fiyatı: {ucBiletFiyati:C}");

        PaymentService paymentService = new PaymentService();
        NotificationService notificationService = new NotificationService();

        TicketOrderService orderService =
            new TicketOrderService(paymentService, notificationService);

        orderService.CompleteOrder(1500);

        List<Customer> customers = new List<Customer>
        {
            new Customer("Gizem", "Koyan", 25),
            new StudentCustomer("Ahmet", "Yılmaz", 20, "2024001"),
            new VipCustomer("Zeynep", "Kaya", 30, 2)
        };

        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.FullName} — {customer.GetCustomerType()}");
            Console.WriteLine(customer.GetAccessMessage());

            if (customer is StudentCustomer student)
            {
                Console.WriteLine($"Öğrenci No: {student.StudentNumber}");
            }
            else if (customer is VipCustomer vip)
            {
                Console.WriteLine($"VIP Seviye: {vip.VipLevel}");
            }

            Console.WriteLine();
        }

        TicketPlan standardPlan = new StandardTicketPlan();
        TicketPlan vipPlan = new VipTicketPlan();

        decimal basePrice = 1000;

        standardPlan.PrintPlanName();
        Console.WriteLine($"Fiyat: {standardPlan.CalculatePrice(basePrice):C}");

        vipPlan.PrintPlanName();
        Console.WriteLine($"Fiyat: {vipPlan.CalculatePrice(basePrice):C}");

        decimal amount = 1000;

        IDiscountStrategy percentageDiscount = new PercentageDiscount(10);
        IDiscountStrategy fixedDiscount = new FixedAmountDiscount(200);

        amount = percentageDiscount.ApplyDiscount(amount);
        Console.WriteLine($"%10 indirim sonrası: {amount:C}");

        amount = fixedDiscount.ApplyDiscount(amount);
        Console.WriteLine($"200 TL indirim sonrası: {amount:C}");

        IAccessValidator ageValidator = new AgeAccessValidator();
        IAccessValidator ticketCodeValidator = new TicketCodeAccessValidator();

        Console.WriteLine($"Yaş 17 giriş yapabilir mi? {ageValidator.CanEnter(17)}");
        Console.WriteLine($"Yaş 20 giriş yapabilir mi? {ageValidator.CanEnter(20)}");

        Console.WriteLine($"Kod 500 giriş yapabilir mi? {ticketCodeValidator.CanEnter(500)}");
        Console.WriteLine($"Kod 2025 giriş yapabilir mi? {ticketCodeValidator.CanEnter(2025)}");

        ReservationService reservationService = new ReservationService(0);

        reservationService.AddTicket(1000, 2);
        reservationService.AddTicket(500, 1);

        reservationService.ApplyDiscount(new PercentageDiscount(10));
        reservationService.ApplyDiscount(new FixedAmountDiscount(200));

        reservationService.PrintSummary();

        TicketStatus status = TicketStatus.Paid;

        Console.WriteLine($"Bilet durumu: {TicketStatusHelper.ToTurkish(status)}");
    }
}
